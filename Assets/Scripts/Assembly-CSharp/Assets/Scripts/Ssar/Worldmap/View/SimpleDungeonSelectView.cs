using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Ssar.Dungeon;
using Assets.Scripts.Utils;
using Scripts.Config;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Ssar.Worldmap.View
{
	// Not part of the original game. The real dungeon/level-select screen is
	// WorldmapPopup + WorldmapRegionView + WorldmapNodeView (Resources/guiprefabs/
	// worldmap/), but that system is entangled with a lot of progression/
	// monetization machinery that's out of scope here (star rewards, lost souls,
	// death-location markers, hell-mode fx, CodeStage-obscured save data) - same
	// "placeholder instead of the full real system" rationale as
	// DungeonSimulationDriver standing in for DungeonFactory's real terrain
	// generation.
	//
	// This is a simplified but genuinely real, data-driven substitute: it reads
	// the actual Resources/config/DungeonConfig.json (201 real dungeon entries
	// across 5 maps x 4 difficulties, via global::Scripts.Config.DungeonConfig, now
	// implemented for real) and lets you pick a real dungeon, then hands off to
	// Dungeon.unity through the existing DungeonSelection contract. Picking
	// different dungeons doesn't yet visually differ - DungeonFactory (real
	// terrain/monster-spawn generation from a dungeon's terrainId/nodeSpawner)
	// is still unimplemented, a separate, larger task.
	public class SimpleDungeonSelectView : MonoBehaviour
	{
		public event Action OnBack;

		private GameObject buttonTemplate;

		private GameObject labelTemplate;

		private global::Scripts.Config.DungeonConfig config;

		private MapInfo currentMap;

		private ScenarioDifficulty currentDifficulty = ScenarioDifficulty.NORMAL;

		private readonly List<GameObject> spawned = new List<GameObject>();

		private static readonly ScenarioDifficulty[] AllDifficulties = new ScenarioDifficulty[4]
		{
			ScenarioDifficulty.NORMAL,
			ScenarioDifficulty.HARD,
			ScenarioDifficulty.HELL,
			ScenarioDifficulty.INSANE
		};

		public void Init(GameObject buttonTemplate, GameObject labelTemplate)
		{
			this.buttonTemplate = buttonTemplate;
			this.labelTemplate = labelTemplate;

			TextAsset json = Resources.Load<TextAsset>("config/DungeonConfig");
			config = new global::Scripts.Config.DungeonConfig();
			if (json != null)
			{
				config.OnMapValue(json.text);
			}
			currentMap = config.GetFirstMap();
		}

		public void Show()
		{
			gameObject.SetActive(true);
			Rebuild();
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}

		private void Rebuild()
		{
			foreach (GameObject go in spawned)
			{
				if (go != null)
				{
					Destroy(go);
				}
			}
			spawned.Clear();

			if (config == null || currentMap == null || buttonTemplate == null || labelTemplate == null)
			{
				return;
			}

			// Map name + difficulty tabs across the top.
			SpawnLabel(currentMap.name, new Vector3(0f, 260f, 0f));
			float tabX = -180f;
			foreach (ScenarioDifficulty difficulty in AllDifficulties)
			{
				ScenarioDifficulty capturedDifficulty = difficulty;
				string label = difficulty == currentDifficulty ? "[" + difficulty + "]" : difficulty.ToString();
				SpawnButton("DifficultyTab_" + difficulty, label, new Vector3(tabX, 200f, 0f), delegate
				{
					currentDifficulty = capturedDifficulty;
					Rebuild();
				});
				tabX += 120f;
			}

			// One real dungeon per row, ordered the same way the real game orders map nodes.
			List<global::Scripts.Config.Dungeon> dungeons = config.GetListDungeons(currentMap.id, currentDifficulty);
			float rowY = 130f;
			foreach (global::Scripts.Config.Dungeon dungeon in dungeons)
			{
				global::Scripts.Config.Dungeon capturedDungeon = dungeon;
				string label = "Node " + dungeon.nodeOrder + " - Dungeon #" + dungeon.id;
				SpawnButton("DungeonRow_" + dungeon.id, label, new Vector3(0f, rowY, 0f), delegate
				{
					EnterDungeon(capturedDungeon);
				});
				rowY -= 70f;
			}

			SpawnButton("BackButton", "Back", new Vector3(0f, rowY - 40f, 0f), delegate
			{
				Hide();
				OnBack?.Invoke();
			});
		}

		private void EnterDungeon(global::Scripts.Config.Dungeon dungeon)
		{
			DungeonSelection.DungeonId = dungeon.id;
			SceneManager.LoadScene(SceneName.DUNGEON);
		}

		private void SpawnLabel(string text, Vector3 localPosition)
		{
			GameObject clone = Instantiate(labelTemplate, transform, worldPositionStays: false);
			clone.transform.localPosition = localPosition;
			clone.SetActive(true);
			UILabel label = clone.GetComponent<UILabel>();
			if (label != null)
			{
				label.text = text;
			}
			spawned.Add(clone);
		}

		private void SpawnButton(string goName, string text, Vector3 localPosition, UIEventListener.VoidDelegate onClick)
		{
			GameObject clone = Instantiate(buttonTemplate, transform, worldPositionStays: false);
			clone.name = goName;
			clone.transform.localPosition = localPosition;
			clone.SetActive(true);
			UILabel label = clone.GetComponentInChildren<UILabel>(includeInactive: true);
			if (label != null)
			{
				label.text = text;
			}
			UIEventListener.Get(clone).onClick += onClick;
			spawned.Add(clone);
		}
	}
}
