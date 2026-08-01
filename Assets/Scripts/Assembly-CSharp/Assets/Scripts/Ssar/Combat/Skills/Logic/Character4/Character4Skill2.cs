using Artemis;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Movement;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character4
{
	public class Character4Skill2 : Character4MeleeSkill
	{
		public class Character4Skill2MovementInfo
		{
			public float phase1StartTime;

			public float phase1DurationInSeconds;

			public float phase2StartTime;

			public float phase2DurationInSeconds;
		}

		private EntityWorld entityWorld;

		private Character4Skill2MovementInfo info;

		private MovementComponent movementComponent;

		private CharacterMediatorComponent characterMediatorComponent;

		private float elapsed;

		private float originalMovementSpeed;

		private bool isJumping;

		private bool isBeingInRecovery;

		private MovementComponent.RunSpeedModifier runSpeedModifier;

		public Character4Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override bool IsInterruptibleWhileChanneling()
		{
			return false;
		}

		public override bool IsMoveable()
		{
			return false;
		}

		public override void Interrupt()
		{
		}

		private void RemoveRunSpeedModifierIfAny()
		{
		}
	}
}
