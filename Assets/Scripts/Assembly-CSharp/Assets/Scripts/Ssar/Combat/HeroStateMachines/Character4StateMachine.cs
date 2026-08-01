using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.HeroStateMachines.States;
using Assets.Scripts.Ssar.Combat.Skills;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public class Character4StateMachine : HeroStateMachine
	{
		public Character4StateMachine(UserInput userInput, Animation animation, Movement movement, Event @event, Hero hero, Character character, EquippedSkills equippedSkills)
			: base(null, null, null, null, null, null, null)
		{
		}

		protected override float JumpToFallAnimationOffset()
		{
			return 0f;
		}

		protected override SkillDecorator.WhiteList WhiteList()
		{
			return null;
		}
	}
}
