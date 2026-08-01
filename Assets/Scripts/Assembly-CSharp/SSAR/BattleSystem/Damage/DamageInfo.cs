using System;
using System.Collections;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills.Modifiers;
using UnityEngine;

namespace SSAR.BattleSystem.Damage
{
	public class DamageInfo
	{
		public class ModifierInfo : Attribute
		{
			private ModifierType modifierType;

			public ModifierType ModifierType => default(ModifierType);

			public ModifierInfo(ModifierType modifierType)
			{
			}
		}

		public class VfxInfo
		{
			private string group;

			private string path;

			public string Group => null;

			public string Path => null;

			public VfxInfo(string group, string path)
			{
			}
		}

		public DamageType damageType;

		public DamageSource damageSource;

		public float damage;

		public Entity caster;

		public Entity target;

		public bool playBeHitVfx;

		public Vector3 collidedProjectilePosition;

		public Vector3 collidedProjectileVelocity;

		public Vector2 collidedProjectileSize;

		public ImmuneType[] targetImmuneTypes;

		public bool IsHealer;

		public float beHitVfxOffsetOnXAxis;

		public bool isIgnoreDef;

		public bool enableHud;

		public Action<float> onDamageDealt;

		public bool isCcImmune;

		private readonly bool isWindbox;

		public DamageCalculateResult result;

		[ModifierInfo(ModifierType.Knockback)]
		public List<KnockbackModifier.KnockbackInfo> knockbackInfos;

		[ModifierInfo(ModifierType.Knockdown)]
		public List<KnockdownModifier.KnockdownInfo> knockdownInfos;

		[ModifierInfo(ModifierType.Stun)]
		public List<StunModifier.StunInfo> stunInfos;

		[ModifierInfo(ModifierType.Shackle)]
		public List<ShackleModifier.ShackleInfo> shackleInfos;

		[ModifierInfo(ModifierType.MovementSpeed)]
		public List<MovementSpeedModifier.MovementSpeedInfo> movementSpeedInfos;

		[ModifierInfo(ModifierType.Attack)]
		public List<AttackModifier.AttackInfo> attackInfos;

		[ModifierInfo(ModifierType.Def)]
		public List<DefModifier.DefInfo> defInfos;

		[ModifierInfo(ModifierType.Burn)]
		public List<BurnModifier.BurnInfo> burnInfos;

		[ModifierInfo(ModifierType.Cursed)]
		public List<CurseModifier.Info> cursedInfos;

		[ModifierInfo(ModifierType.Freeze)]
		public List<FreezeModifier.Info> freezeInfos;

		[ModifierInfo(ModifierType.Scream)]
		public List<ScreamModifier.Info> screamInfos;

		[ModifierInfo(ModifierType.ColdBurn)]
		public List<ColdBurnModifier.Info> coldBurnInfos;

		[ModifierInfo(ModifierType.Shock)]
		public List<ShockModifier.ShockInfo> shockInfos;

		[ModifierInfo(ModifierType.Bleed)]
		public List<BleedModifier.Info> bleedInfos;

		[ModifierInfo(ModifierType.BloodBond)]
		public List<BloodBondModifier.Info> bloodBondInfos;

		[ModifierInfo(ModifierType.Silent)]
		public List<SilentModifier.Info> silentInfos;

		[ModifierInfo(ModifierType.InstantDeath)]
		public List<InstantDeathModifier.Info> deathInfos;

		[ModifierInfo(ModifierType.DamageReduction)]
		public List<DamageReductionModifier.Info> damageReductionInfos;

		[ModifierInfo(ModifierType.Poison)]
		public List<PoisonModifier.Info> poisonInfos;

		[ModifierInfo(ModifierType.Frost)]
		public List<FrostModifier.Info> frostInfos;

		[ModifierInfo(ModifierType.Devour)]
		public List<DevourModifier.Info> devourInfos;

		[ModifierInfo(ModifierType.Bubble)]
		public List<BubbleModifier.Info> bubbleInfos;

		[ModifierInfo(ModifierType.Hp)]
		public List<HpModifier.HpInfo> hpInfos;

		public List<object> modifierObjects;

		public List<ModifierType> modifierTypes;

		public List<VfxInfo> preferredVfxInfos;

		public bool IsWindbox => false;

		public DamageInfo(DamageSource damageSource, DamageType damageType, Entity caster, Entity target, float damage, bool playBeHitVfx = true, bool isHealer = false)
		{
		}

		public DamageInfo(DamageSource damageSource, DamageType damageType, Entity caster, Entity target, float damage, Vector3 collidedProjectilePosition, Vector3 collidedProjectileVelocity, Vector2 collidedProjectileSize, ImmuneType[] targetImmuneTypes, bool isCcImmune, bool isWindbox = false, bool playBeHitVfx = true, bool isHealer = false, bool isIgnoreDef = false, Action<float> onDamageDealt = null)
		{
		}

		public float GetFinalHealthChange()
		{
			return 0f;
		}

		public void AddPreferredVfxInfo(VfxInfo vi)
		{
		}

		public void AddKnockbackInfo(KnockbackModifier.KnockbackInfo info)
		{
		}

		private void AddModifierObjectAndModifierType(object mo, ModifierType mt)
		{
		}

		public void AddKnockdownInfo(KnockdownModifier.KnockdownInfo info)
		{
		}

		public void AddStunInfo(StunModifier.StunInfo info)
		{
		}

		public void ClearModifiersInfo()
		{
		}

		public void AddShackleInfo(ShackleModifier.ShackleInfo shackleInfo)
		{
		}

		public ImmuneType[] GetTargetImmuneTypes()
		{
			return null;
		}

		public void AddMovementSpeedInfo(MovementSpeedModifier.MovementSpeedInfo movementSpeedInfo)
		{
		}

		public void AddAttackInfo(AttackModifier.AttackInfo attackInfo)
		{
		}

		public void AddDefInfo(DefModifier.DefInfo defInfo)
		{
		}

		public void AddBurnInfo(BurnModifier.BurnInfo burnInfo)
		{
		}

		public void AddColdBurnInfo(ColdBurnModifier.Info info)
		{
		}

		public void AddShockInfo(ShockModifier.ShockInfo info)
		{
		}

		public void AddBleedInfo(BleedModifier.Info info)
		{
		}

		public void AddCursedInfo(CurseModifier.Info cursedInfo)
		{
		}

		public void AddFreezeInfo(FreezeModifier.Info freezeInfo)
		{
		}

		public void AddScreamInfo(ScreamModifier.Info si)
		{
		}

		public void AddBloodBondInfo(BloodBondModifier.Info bloodInfo)
		{
		}

		public void AddSilentInfo(SilentModifier.Info silentInfo)
		{
		}

		public void AddDeathInfo(InstantDeathModifier.Info deathInfo)
		{
		}

		public void AddDamageReductionInfo(DamageReductionModifier.Info damageReductionInfo)
		{
		}

		public void AddPoisonInfo(PoisonModifier.Info info)
		{
		}

		public void AddFrostInfo(FrostModifier.Info info)
		{
		}

		public void AddDevourInfo(DevourModifier.Info info)
		{
		}

		public void AddBubbleInfo(BubbleModifier.Info info)
		{
		}

		public void AddHpInfo(HpModifier.HpInfo info)
		{
		}

		public void ClearKnockbackInfos()
		{
		}

		public void ClearKnockdownInfos()
		{
		}

		public void RemoveKnockdownInfoAt(int index)
		{
		}

		public void RemoveKnockbackInfoAt(int index)
		{
		}

		public void SetIgnoreDef(bool isIgnoreDef)
		{
		}

		public DamageInfo SetEnableHUD(bool enableHUd)
		{
			return null;
		}

		public IList ClearModifierOtherThan(ModifierType modifierTypeToKeep, Dictionary<ModifierType, bool> whiteList = null)
		{
			return null;
		}
	}
}
