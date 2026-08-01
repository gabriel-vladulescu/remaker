using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class Move
	{
		private float distance;

		private float endFrame;

		private float blendTime;

		private bool isFromUserInput;

		private bool adjustCollider;

		private Vector2 moveColliderCenter;

		private Vector2 moveColliderSize;

		private string extras;

		private readonly bool moveBackward;

		private readonly bool moveTowardTarget;

		private readonly AnimationCurve curve;

		private readonly float maxSpeed;

		private readonly bool ignoreMoveDirection;

		public float Distance => 0f;

		public float EndFrame => 0f;

		public float BlendTime => 0f;

		public bool AdjustCollider => false;

		public Vector2 MoveColliderCenter => default(Vector2);

		public Vector2 MoveColliderSize => default(Vector2);

		public string Extras => null;

		public bool IsFromUserInput => false;

		public bool MoveBackward => false;

		public bool MoveTowardTarget => false;

		public AnimationCurve Curve => null;

		public float MaxSpeed => 0f;

		public bool IgnoreMoveDirection => false;

		public Move(float distance, float endFrame, float blendTime, bool adjustCollider, Vector2 moveColliderCenter, Vector2 moveColliderSize, string extras, bool isFromUserInput = false, bool moveBackward = false, bool moveTowardTarget = false, AnimationCurve curve = null, float maxSpeed = 0f, bool ignoreMoveDirection = false)
		{
		}
	}
}
