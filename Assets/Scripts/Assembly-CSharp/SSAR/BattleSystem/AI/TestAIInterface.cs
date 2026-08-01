using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.Model;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class TestAIInterface : BasePopup
	{
		public string defaultID;

		public float defaultHeight;

		public Vector3 spawnPos;

		public UIInput lb_id;

		public UIInput lb_height;

		public GameObject btn_spawn;

		private DungeonConfig dungeonConfig;

		private Dictionary<string, string> skillPrefabPaths;

		private MobSpawnInfo mob;

		private int totalMonsterCount;

		private int loadedMonsterCount;

		private Dictionary<GameObject, int> totalByMonsterPrefab;

		private Dictionary<GameObject, int> loadedByMonsterPrefab;

		private const string CACHE_MONSTER_ID = "cacheMonsterId";

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Spawn(GameObject o)
		{
		}

		private void OnLoadMonsterPrefabSuccess(object asset)
		{
		}

		private List<string> FindMinionsOfSpawnerSkill(SkillEventFrameConfig sefc)
		{
			return null;
		}

		private void RegisterSkillPrefabsOfMinionsOfSpawnerSkill(List<string> minionMonsterIds, GameObject spawnerMonsterPrefab)
		{
		}

		private void OnLoadMinionPrefabOfSpawnerSkillSuccess(object prefab)
		{
		}

		private void PreloadSkillPrefabs(List<string> skillPrefabPaths)
		{
		}

		private void OnPreloadComplete()
		{
		}

		private void TestWin()
		{
		}

		public void SetDungeonConfig(DungeonConfig dungeonConfig)
		{
		}

		private MobSpawnInfo GenerateMobSpawnInfo(string id)
		{
			return null;
		}
	}
}
