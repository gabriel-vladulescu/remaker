using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class DisplaceByRequest : AbsRequest
	{
		private int count;

		private Vector3 displacement;

		public DisplaceByRequest(AccessLevel accessLevel, Vector3 displacement)
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
