using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75001;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster2002
{
	public class Monster2002IceShardSkill : Monster75001Skill1
	{
		public Monster2002IceShardSkill(Dependencies dependencies)
			: base(null)
		{
		}

		protected override Vector3 OverrideProjectilePositionForRangerProjectileTowardTarget(EventFrame ef, Vector3 currentPosition)
		{
			return default(Vector3);
		}
	}
}
