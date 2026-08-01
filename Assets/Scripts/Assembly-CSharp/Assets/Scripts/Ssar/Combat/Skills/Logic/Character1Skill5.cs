using Artemis;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Movement;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character1Skill5 : DefaultMeleeSkill
	{
		public class Character1Skill5MovementInfo
		{
			public float phase1StartTime;

			public float phase1DurationInSeconds;

			public string phase1Anim;

			public float phase2StartTime;

			public float phase2DurationInSeconds;

			public string phase2Anim;
		}

		private EntityWorld entityWorld;

		private Character1Skill5MovementInfo info;

		private MovementComponent movementComponent;

		private CharacterMediatorComponent characterMediatorComponent;

		private float elapsed;

		private float originalMovementSpeed;

		private bool isJumping;

		private bool isBeingInRecovery;

		private MovementComponent.RunSpeedModifier runSpeedModifier;

		private bool animPhase1Played;

		private bool animPhase2Played;

		public Character1Skill5(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override bool IsMoveable()
		{
			return false;
		}

		public override bool IsJumpable()
		{
			return false;
		}

		public override void OnJumpBegin()
		{
		}

		public override void OnJumpEnd()
		{
		}

		public override void Interrupt()
		{
		}

		private void RemoveRunSpeedModifierIfAny()
		{
		}
	}
}
