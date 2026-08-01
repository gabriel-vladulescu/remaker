using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class DashRequest : AbsRequest
	{
		private float time;

		private float minSpeedOnAir;

		private DashData dashData;

		private EasingFunctions.EasingFunc _dashDerivativeFunction;

		private MovementComponent movement;

		private CharacterMediatorComponent _characterMediator;

		private bool forceClearVelocityXToZeroWhenFinish;

		private bool influenceByEnvironment;

		private readonly bool isFromUserInput;

		private AbsGravityControl gravityControl;

		public float MinSpeedOnAir
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public DashRequest(AccessLevel accessLevel, DashData dashData, bool influenceByEnvironment = false, bool isFromUserInput = false)
			: base(default(AccessLevel))
		{
		}

		public DashRequest SetForceClearVelocityXWhenFinish()
		{
			return null;
		}

		public override void OnAttach()
		{
		}

		private void OnCollision(CollisionFlags collisionFlags)
		{
		}

		public override void Update(float deltaTime)
		{
		}

		public override bool Expired()
		{
			return false;
		}

		public override void Exit()
		{
		}

		public override int Priority()
		{
			return 0;
		}

		public override bool InfluenceByEnvironment()
		{
			return false;
		}

		private float GetSpeed()
		{
			return 0f;
		}

		private AbsGravityControl GetGravityControl()
		{
			return null;
		}

		public void SetGravityControl(AbsGravityControl gravityControl)
		{
		}
	}
}
