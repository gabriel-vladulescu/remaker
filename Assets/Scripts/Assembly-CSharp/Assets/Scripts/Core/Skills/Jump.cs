namespace Assets.Scripts.Core.Skills
{
	public class Jump
	{
		private int count;

		private float height;

		private float durationReachMaxHeight;

		private float distance;

		private float durationLandGround;

		private readonly bool isFromSignatureSkill;

		private bool disableOnGround;

		private float floatingDuration;

		private bool jumpBackward;

		public int Count => 0;

		public float Height => 0f;

		public float DurationReachMaxHeight => 0f;

		public float Distance => 0f;

		public float DurationLandGround => 0f;

		public bool IsFromSignatureSkill => false;

		public bool DisableOnGround => false;

		public float FloatingDuration => 0f;

		public bool JumpBackward => false;

		public Jump(int count, float height, float durationReachMaxHeight, float distance, float durationLandGround, bool isFromSignatureSkill, bool disableOnGround, float floatingDuration = 0f, bool jumpBackward = false)
		{
		}

		public void SetDistance(float distance)
		{
		}
	}
}
