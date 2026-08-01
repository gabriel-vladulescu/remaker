using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Artemis;
using Artemis.System;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.Dungeon.Caching;
using SSAR.Dungeon.HUD;
using UnityEngine;

namespace SSAR.BattleSystem.Damage
{
	public class DamageCalculationSystem : EntityProcessingSystemWithTime
	{
		public delegate void EntityDeath(Entity entity);

		public delegate void OnEntityDealDamage(int id, float damage);

		public delegate void OnEntityBeDealDamage(int id, int casterId, float damage, DamageSource damageSource);

		private Action<DamageInfo> onEntityTakeHpChange;

		private Action<Character, Character> onEntityDeathByAttacker;

		private BattleMode battleMode;

		public bool enableUpdate;

		private int frame;

		private bool isDisableDamageText;

		private bool isDisableDeathEffects;

		public static event EntityDeath entityDeathEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event OnEntityDealDamage On_EntityDealDamage
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event OnEntityBeDealDamage On_EntityBeDealDamage
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public DamageCalculationSystem(BattleMode battleMode, bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		public void ListenToEntityDeathByAttacker(Action<Character, Character> listener)
		{
		}

		public void ListenToEntityDeath(EntityDeath listener)
		{
		}

		public void ListenOnDealDamage(OnEntityDealDamage listener)
		{
		}

		public void UnListenOnDealDamage(OnEntityDealDamage listener)
		{
		}

		public void ListenOnBeDealDamage(OnEntityBeDealDamage listener)
		{
		}

		public void UnListenToEntityDeathByAttacker(Action<Character, Character> listener)
		{
		}

		public void UnListenOnBeDealDamage(OnEntityBeDealDamage listener)
		{
		}

		public void ListenOnEnityTakeHpChange(Action<DamageInfo> callback)
		{
		}

		public void UnListenOnEntityTakeHpChange(Action<DamageInfo> callback)
		{
		}

		public void UpdateDisplayDamageText()
		{
		}

		public void UpdateDisplayDeathEffects()
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}

		private void AutoRecoveryHp(Entity entity, float deltaTime)
		{
		}

		private void PostDamageCalculation(DamageInfo damageInfo)
		{
		}

		private void OnCasterPostDamageCalculation(DamageInfo damageInfo)
		{
		}

		private void OnBeforeTakingHpchange(DamageInfo damageInfo)
		{
		}

		private void OnAfterTakingHpChange(DamageInfo damageInfo)
		{
		}

		private static void PlayBeHitSoundFx(DamageInfo damageInfo)
		{
		}

		private static void PlayVfx(DamageInfo damageInfo, EffectPathIndex effectPathIndex)
		{
		}

		private static void PlaySfx(UISfx uiSfx)
		{
		}

		private void EntityDie(Entity attacker, Entity defender)
		{
		}

		private void GenerateBehitEffect(float damage, Entity caster, Entity target, float offsetX, EffectPathIndex characterFx, EffectPathIndex monsterFx, Vector3 offsetPosition, List<DamageInfo.VfxInfo> preferredVfxInfos = null)
		{
		}

		private bool CheckIfThereAreAnyPreferredVfxInfo(string entityGroup, List<DamageInfo.VfxInfo> preferredVfxInfos, ref string vfxPath)
		{
			return false;
		}

		private void SetHUDIndicator(DamageType damageType, float damage, HUDMediatorComponent hud, HealthComponent health, bool critFlag = false, bool isImmune = false, bool isDodge = false, bool isHealer = false, float beHitVfxOffsetOnXAxis = 0f, bool isIgnoreDef = false, bool isBlock = false, bool isMiss = false)
		{
		}

		private void FlashCharacter(CachingComponent cm, DamageType dealerType)
		{
		}

		private FlashType GetFlashType(DamageType damageType)
		{
			return default(FlashType);
		}

		private void ShakeCamera()
		{
		}

		private void ForceFinishFlash(CachingComponent cm)
		{
		}

		public void Calculate(ref DamageInfo damageInfo)
		{
		}

		private void HandleDamageBlock(DamageInfo damageInfo, Character targetCharacter, Character casterCharacter, DamageCalculateResult result)
		{
		}

		private static void HandleReduceDamageByDistance(DamageInfo damageInfo, Character targetCharacter, Character casterCharacter, DamageCalculateResult result)
		{
		}

		private static void HandleReduceDamagePercentage(DamageInfo damageInfo, Character targetCharacter, Character casterCharacter, DamageCalculateResult result)
		{
		}

		private DamageData GenerateDamageData(DamageInfo damageInfo)
		{
			return null;
		}

		public void OnEntityDeathNotBecauseOfZeroHealth(Entity entity)
		{
		}
	}
}
