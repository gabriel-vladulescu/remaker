using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class UpdatePositionRequest : AbsRequest
	{
		private float count;

		private Vector3 targetPosition;

		public UpdatePositionRequest(AccessLevel accessLevel, Vector3 targetPosition)
			: base(default(AccessLevel))
		{
		}

		public override void OnAttach()
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
