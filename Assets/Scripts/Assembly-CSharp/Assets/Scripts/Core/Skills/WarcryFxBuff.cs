using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class WarcryFxBuff : Buff
	{
		private float defBonus;

		private float attackBonus;

		private string startupFxPath;

		private string activeFxPath;

		private Vector3 offset;

		private Vector3 scale;

		public float DefBonus => 0f;

		public float AttackBonus => 0f;

		public string StartupFxPath => null;

		public string ActiveFxPath => null;

		public Vector3 Offset => default(Vector3);

		public Vector3 Scale => default(Vector3);

		public WarcryFxBuff(BuffTargetModeInfo buffTargetModeInfo, float duration, float successRate, float defBonus, float attackBonus, bool isLifeCycleDependOnParentSkill, string startupFxPath, string activeFxPath, Vector3 offset, Vector3 scale)
			: base(default(BuffType), null, 0f, 0f, isLifeCycleDependOnParentSkill: false)
		{
		}

		public void SetAttackBonus(float bonus)
		{
		}

		public void SetDefBonus(float bonus)
		{
		}
	}
}
