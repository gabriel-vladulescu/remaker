using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster2000003
{
	public class Monster2000003RangerSkill : DefaultRangerSkill
	{
		private EventFrame damageEventFrame;

		public Monster2000003RangerSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		private Vector2 GenerateProjectileVelocity(Vector2 startPos, float speed)
		{
			return default(Vector2);
		}

		private Vector3 GetTargetBodyPosition(Character target)
		{
			return default(Vector3);
		}
	}
}
