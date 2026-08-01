using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class TweenMaterialFloat : UITweener
	{
		public float from;

		public float to;

		public string property;

		private float _mValue;

		private SkinnedMeshRenderer skin;

		public float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		protected override void OnUpdate(float factor, bool isFinished)
		{
		}

		public static TweenMaterialFloat Begin(GameObject go, string property, float duration, float from, float to)
		{
			return null;
		}

		[ContextMenu("Set 'From' to current value")]
		public override void SetStartToCurrentValue()
		{
		}

		[ContextMenu("Set 'To' to current value")]
		public override void SetEndToCurrentValue()
		{
		}

		[ContextMenu("Assume value of 'From'")]
		private void SetCurrentValueToStart()
		{
		}

		[ContextMenu("Assume value of 'To'")]
		private void SetCurrentValueToEnd()
		{
		}
	}
}
