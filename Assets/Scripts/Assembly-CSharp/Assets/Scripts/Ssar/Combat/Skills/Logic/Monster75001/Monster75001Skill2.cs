using Artemis;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Skills.Logic.Character2;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75001
{
	public class Monster75001Skill2 : Character2Skill5
	{
		private Direction facingDirectionAtCasting;

		private Vector2 centerPivotAtCasting;

		public Monster75001Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected override Vector2 CenterPivot()
		{
			return default(Vector2);
		}
	}
}
