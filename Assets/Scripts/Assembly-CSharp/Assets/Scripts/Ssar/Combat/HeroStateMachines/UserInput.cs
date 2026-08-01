namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public interface UserInput
	{
		bool IsInputRun();

		bool IsInputDash();

		bool IsInputJump();

		bool IsInputAttack();

		bool IsInputSkill();

		string SkillId();

		bool IsInputRunInOppositeDirection();

		void OnSkillCastingRequestConsumed();

		bool IsHoldingAttack();
	}
}
