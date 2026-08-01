using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class SkillEventFrameConfig : MonoBehaviour, ISerializationCallbackReceiver
	{
		public new string name;

		public List<SkillConfig> skillConfigs;

		public static EventFrameConfig eventFrameConfigClipboard;

		public static ModifierConfig modifierConfigClipboard;

		public static SkillConfig skillConfigClipboard;

		public string[] BoneNames()
		{
			return null;
		}

		public void VerifyBoneNames(string[] inputNames)
		{
		}

		public void SwapSkillConfig(int i, int j)
		{
		}

		public SkillConfig FindSkillConfigBySkillStatsId(string skillStatsId)
		{
			return null;
		}

		private void DrawSkillSpecificGizmos(SkillConfig skillConfig)
		{
		}

		public void DrawGizmos()
		{
		}

		public void CopyEventFrameConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
		}

		public void PasteEventFrameConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
		}

		public void GoUpEventFrameConfig(int skillConfigIndex, int index)
		{
		}

		public void GoDownEventFrameConfig(int skillConfigIndex, int index)
		{
		}

		public void CopyModifierConfig(int skillConfigIndex, int modifierConfigIndex)
		{
		}

		public void PasteModifierConfig(int skillConfigIndex, int modifierConfigIndex)
		{
		}

		public void GoUpModifierConfig(int skillConfigIndex, int index)
		{
		}

		public void GoDownModifierConfig(int skillConfigIndex, int index)
		{
		}

		public void CopySkillEventFrameConfig(int skillConfigIndex)
		{
		}

		public void PasteSkillEventFrameConfig(int skillConfigIndex)
		{
		}

		public static T DeepClone<T>(T obj)
		{
			return default(T);
		}

		public void AddNewEventFrameOfImmuneBuff(int skillIndex)
		{
		}

		public BuffConfig ChangeBuffConfigToImmune(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig ChangeBuffConfigToMovementSpeed(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig ChangeBuffConfigToAttack(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDefBuffConfig(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateBurnBuffConfig(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateColdBurnConfig(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateHpBuffConfig(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateInstantHpBuffConfig(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateReduceDamageByDistanceBuffConfig(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateReduceDamagePercentageByDistanceBuffConfig(int skillIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateCritDamageBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateAttackOverrideBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateCritRateOverrideBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateSkillCritRateBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateHolyBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateWarcryBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateWarcryFxBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateBlessBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateWildHowBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateBleedBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateMaxHpOverrideBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDefOverrideBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateMagicResistOverrideBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateVanishBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDamageBlockBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateKnockbackWeightBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateKnockdownWeightBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDisableJumpBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDarkArcaneBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateCcImmuneBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateHardCcImmuneBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDamageImmuneBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateBloodBondBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreatePosionBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateSilentBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDevourBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateSkillDamageBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateMagicDamageBlockBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDodgeBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateDamageReductionBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public BuffConfig CreateCooldownBuffConfig(int skillConfigIndex, int eventFrameConfigIndex)
		{
			return null;
		}

		public void ChangeBuffTargetModeToSelf(int skillIndex, int eventFrameConfigIndex)
		{
		}

		public void ChangeBuffTargetModeToAoe(int skillIndex, int eventFrameConfigIndex)
		{
		}

		public static string JsonSerialize(object obj)
		{
			return null;
		}

		public static T JsonDeserialize<T>(string json)
		{
			return default(T);
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
