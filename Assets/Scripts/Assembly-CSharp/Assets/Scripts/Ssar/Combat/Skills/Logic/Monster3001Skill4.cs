using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Moves;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Monster3001Skill4 : DefaultMeleeSkill
	{
		private float frame;

		private float duration;

		public Monster3001Skill4(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnMoveTowardDirection(EventFrame ef, Assets.Scripts.Core.Skills.Moves.MoveTowardDirection m)
		{
		}

		private void RestrictFlyDirectionToFacingDirection(Assets.Scripts.Core.Skills.Moves.MoveTowardDirection m)
		{
		}

		protected override void OnFlyUpward(EventFrame ef, Assets.Scripts.Core.Skills.Moves.FlyUpward fu)
		{
		}
	}
}
