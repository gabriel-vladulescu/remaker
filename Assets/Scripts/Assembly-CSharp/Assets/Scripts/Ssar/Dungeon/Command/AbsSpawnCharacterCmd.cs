using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Config.Stats;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.EntityTemplate;
using Scripts.Config;
using UnityEngine;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public abstract class AbsSpawnCharacterCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CReenableCharacter_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Entity main;

			public AbsSpawnCharacterCmd _003C_003E4__this;

			private GameObject _003Cp_003E5__2;

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
			public _003CReenableCharacter_003Ed__34(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitThenRecoverFullHp_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Character character;

			public Entity entity;

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
			public _003CWaitThenRecoverFullHp_003Ed__36(int _003C_003E1__state)
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

		private GameObject mainCharPrefab;

		private GameObject cosmeticWeaponPrefab;

		private bool errorWhenLoadCosmeticWeaponPrefab;

		private HeroData heroData;

		private int dungeonId;

		private int level;

		[Inject]
		public ResourcesLoader ResourcesLoader { get; set; }

		[Inject]
		public IBattleModeLogic battleModeLogic { get; set; }

		[Inject]
		public ConfigManager ConfigManager { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public List<GameObject> weaponPassiveSkillPrefabs { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public List<GameObject> ancientSkillPrefabs { get; set; }

		public override void Execute()
		{
		}

		private void Spawn()
		{
		}

		private void LoadCosmeticWeaponPrefab(MainCharacterData mcd, EquipmentVisualConfig equipmentConfig)
		{
		}

		private void OnLoadComplete()
		{
		}

		private void ContinueNextWork()
		{
		}

		private void AdjustDashShadow(GameObject chestArmorPrefab, GameObject heroGameObject, string weaponJointName)
		{
		}

		private void CastWeaponPassiveSkills(Entity heroEntity, HeroData heroData)
		{
		}

		private void CastAncientPassiveSkill(Entity heroEntity, HeroData heroData)
		{
		}

		[IteratorStateMachine(typeof(_003CReenableCharacter_003Ed__34))]
		private IEnumerator ReenableCharacter(Entity main, HeroData heroData)
		{
			return null;
		}

		private void CastPassiveSkills(Entity heroEntity, int groupId, int subId, int level, SkillEquippedData csd)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenRecoverFullHp_003Ed__36))]
		private IEnumerator WaitThenRecoverFullHp(HealthComponent hc, Character character, Entity entity)
		{
			return null;
		}

		private void ReplaceWeapon(GameObject o, MainCharacterData mainCharacterData, IBattleModeLogic battleModeLogic)
		{
		}

		private GameObject[] ReplaceChestArmor(GameObject o, MainCharacterData mainCharacterData, IBattleModeLogic battleModeLogic)
		{
			return null;
		}

		private void ReplaceHelmet(GameObject o, MainCharacterData mainCharacterData, IBattleModeLogic battleModeLogic)
		{
		}

		private void ReplaceWing(GameObject o, MainCharacterData mainCharacterData, IBattleModeLogic battleModeLogic, ResourcesLoader ResourcesLoader)
		{
		}

		private void AddIconWeaponPassive(MainCharacterData mainCharacterData, Entity entity)
		{
		}

		protected virtual bool EnableModifyStatTest()
		{
			return false;
		}

		protected virtual bool EnableSummonPest()
		{
			return false;
		}

		protected abstract MainCharacterData MainCharacterData();

		protected abstract Vector3 PositionSpawn();

		protected abstract Entity CreateEntityFromTemplate(MainCharacterTemplateArgs args);

		protected abstract void CreateEntityFinish(Entity entity);
	}
}
