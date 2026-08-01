using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class DashData
	{
		private float dashDistance;

		private float dashDuration;

		private float blendTime;

		private bool backward;

		private bool ignoreMoveDirection;

		private AnimationCurve curve;

		private float maxSpeed;

		public float DashDistance => dashDistance;

		public float DashDuration => dashDuration;

		public float BlendTime => blendTime;

		public bool Backward => backward;

		public AnimationCurve Curve => curve;

		public float MaxSpeed => maxSpeed;

		public bool IgnoreMoveDirection => ignoreMoveDirection;

		public DashData SetData(float dashDistance, float dashDuration, float blendTime = -1f, bool backward = false, AnimationCurve curve = null, float maxSpeed = 0f, bool ignoreMoveDirection = false)
		{
			this.dashDistance = dashDistance;
			this.dashDuration = dashDuration;
			this.blendTime = blendTime >= 0f ? blendTime : dashDuration;
			this.backward = backward;
			this.curve = curve;
			this.maxSpeed = maxSpeed > 0f ? maxSpeed : (dashDuration > 0f ? dashDistance / dashDuration : 0f);
			this.ignoreMoveDirection = ignoreMoveDirection;
			return this;
		}
	}
}
