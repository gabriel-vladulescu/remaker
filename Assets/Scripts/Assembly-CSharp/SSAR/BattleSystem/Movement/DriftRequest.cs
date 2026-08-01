using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class DriftRequest : AbsRequest
	{
		private float time;

		private DashData dashData;

		private EasingFunctions.EasingFunc _dashDerivativeFunction;

		private MovementComponent movement;

		private CharacterMediatorComponent _characterMediator;

		private bool forceClearVelocityXToZeroWhenFinish;

		public DriftRequest(AccessLevel accessLevel, DashData dashData)
			: base(default(AccessLevel))
		{
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
	}
}
