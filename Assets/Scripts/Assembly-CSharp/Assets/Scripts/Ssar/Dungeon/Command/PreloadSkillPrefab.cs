using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Config.Stats;
using Assets.Scripts.Ssar.Combat.Skills;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using UnityEngine;
using strange.extensions.injector.api;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class PreloadSkillPrefab
	{
		public class SkillPrefabPaths
		{
			private Dictionary<string, string> skillPrefabPaths;

			private Dictionary<string, string> containerNames;

			private Dictionary<string, string> fieldNames;

			private int i;

			public SkillPrefabPaths(SkillEventFrameConfig sefc)
			{
			}

			public IEnumerable<string> Obtain()
			{
				return null;
			}

			private void ExtractPaths(object obj)
			{
			}

			public Dictionary<string, string> GetSkillPrefabPaths()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PreloadSkillPrefab _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelay_003Ed__49(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private int total;

		private int loaded;

		private Dictionary<string, string> skillPrefabPaths;

		private Dictionary<GameObject, int> monsterPrefabs;

		private bool isHeroEquipCosmeticWeapon;

		private GameObject cosmeticWeaponPrefab;

		private List<GameObject> weaponPassiveSkillPrefabs;

		private List<GameObject> ancientSkillPrefabs;

		private int loadedCount;

		private int ancientLoadedCount;

		private HeroData heroData;

		private int level;

		private bool isFxFromCosmeticWeaponUsed;

		private IInjectionBinder injectionBinder;

		private MainCharacterData mainCharacterData;

		private Action onComplete;

		private Dictionary<GameObject, int> totalByMonsterPrefab;

		private Dictionary<GameObject, int> loadedByMonsterPrefab;

		public ResourcesLoader resourcesLoader { get; set; }

		public Assets.Scripts.Ssar.Dungeon.Configs.DungeonConfig dungeonConfig { get; set; }

		public ConfigManager configManager { get; set; }

		public IBattleModeLogic battleModeLogic { get; set; }

		public PreloadSkillPrefab(MainCharacterData mainCharacterData, IInjectionBinder injectionBinder, ResourcesLoader resourcesLoader, IBattleModeLogic battleModeLogic, ConfigManager configManager, Assets.Scripts.Ssar.Dungeon.Configs.DungeonConfig dungeonConfig, Action onComplete)
		{
		}

		public void Execute()
		{
		}

		private void LoadPrefabs(MainCharacterData mainCharacterData, EquipmentVisualConfig ec)
		{
		}

		private void LoadWeaponPassiveSkillPrefabs(MainCharacterData mainCharacterData, EquipmentVisualConfig ec)
		{
		}

		private void LoadAncientSkillPrefabs()
		{
		}

		private void LoadHeroAndMonsters()
		{
		}

		private void LoadMonster()
		{
		}

		private void LoadHero()
		{
		}

		private void LoadArcaneForm()
		{
		}

		private void LoadPet()
		{
		}

		private void LoadMonsterSuccess(object prefab)
		{
		}

		private void LoadHeroSuccess(object prefab)
		{
		}

		private void LoadPetSuccess(object prefab)
		{
		}

		private void OnLoadPrefabSuccess(object prefab, bool isMonster, int initCount = 1)
		{
		}

		private void CheckDone()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__49))]
		private IEnumerator Delay()
		{
			return null;
		}

		private List<string> FindMinionsOfSpawnerSkill(GameObject obj)
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

		public static Dictionary<string, string> SkillPathInPrefabDict(GameObject prefab)
		{
			return null;
		}

		public static List<string> SkillPathInPrefab(GameObject prefab)
		{
			return null;
		}
	}
}
