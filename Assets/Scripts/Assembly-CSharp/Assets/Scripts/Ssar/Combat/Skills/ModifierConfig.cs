using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class ModifierConfig
	{
		public int triggerType;

		public int modifierType;

		public float successRate;

		public float knockbackLevel;

		public float knockbackDashDistance;

		public float knockbackDashDuration;

		public bool knockbackShouldInterruptTargetSkill;

		public bool knockbackTowardProjectile;

		public bool useCasterPositionForKnockbackDirection;

		public bool alwaysKnockbackAccordingToCasterFacingDirection;

		public float knockdownLevel;

		public float knockdownJumpHeight;

		public float knockdownJumpDurationReachMaxHeight;

		public float knockdownJumpDurationLandGround;

		public float knockdownJumpDistance;

		public float knockdownDuration;

		public bool useCasterPositionForKnockdownDirection;

		public bool useCasterFacingDirectionForKnockdownDirection;

		public bool useProjectileVelocityForKnockdownDirection;

		public float knockdownFloatingDuration;

		public bool shouldPerformBouncing;

		public float stunDuration;

		public bool stunPlayVfx;

		public float stunAnimTransitionTime;

		public float shackleDuration;

		public bool shacklePlayVfx;

		public string configString;

		public string cameraFxConfigString;

		[NonSerialized]
		public CameraFxConfig cameraFxConfig;

		public string soundFxConfigString;

		[NonSerialized]
		public SoundFxConfig soundFxConfig;

		public string castSkillConfigString;

		[NonSerialized]
		public CastSkillConfig castSkillConfig;

		public string castProjectileConfigString;

		[NonSerialized]
		public CastProjectileConfig castProjectileConfig;

		public string castSpawnMonsterConfigString;

		[NonSerialized]
		public CastSpawnMonsterConfig castSpawnMonsterConfig;

		public string adjustTimeFrameConfigString;

		[NonSerialized]
		public AdjustTimeFrameConfig adjustTimeFrameConfig;

		public string playVfxConfigString;

		[NonSerialized]
		public PlayVfxConfig playVfxConfig;

		public string hpDropAttackBuffConfigString;

		[NonSerialized]
		public HpDropAttackBuffConfig hpDropAttackBuffConfig;

		public string beHitBlastWaveConfigString;

		[NonSerialized]
		public BeHitBlastWaveConfig beHitBlastWaveConfig;

		public string hitTargetInstantKillConfigString;

		[NonSerialized]
		public HitTargetInstantKillConfig hitTargetInstantKillConfig;

		public string hitTargetCastSkillConfigString;

		[NonSerialized]
		public HitTargetCastSkillConfig hitTargetCastKillConfig;

		public string hpDropUsePotionConfigString;

		[NonSerialized]
		public HpDropUsePotionConfig hpDropUsePotionConfig;

		public string comboDamageFrameShockwaveConfigString;

		[NonSerialized]
		public ComboDamageFrameShockwaveConfig comboDamageFrameShockwaveConfig;

		public string soundFxRandomlyConfigString;

		[NonSerialized]
		public SoundFxRandomlyConfig soundFxRandomlyConfig;

		public string weaponPassiveSkillConfigString;

		[NonSerialized]
		public WeaponPassiveSkillConfig weaponPassiveSkillConfig;

		public TriggerType TriggerTypeValue()
		{
			return default(TriggerType);
		}

		public ModifierType ModifierTypeValue()
		{
			return default(ModifierType);
		}

		public BuffConfig GetConfigObject()
		{
			return null;
		}

		public void OnAfterDeserialize(SkillEventFrameConfig config)
		{
		}

		public WeaponPassiveSkillConfig GetPassiveSkillConfig()
		{
			return null;
		}
	}
}
