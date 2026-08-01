using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	public class SubHpBarView : MonoBehaviour
	{
		public UISlider target;

		private UISlider slider;

		private float duration;

		private bool hasInit;

		private const float SMOOTH_FACTOR = 5f;

		private const float DEFAULT_DURATION = 2.5f;

		private const float DELAY_AT_BEGIN = 0.2f;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateValue()
		{
		}

		private void ForceUpdateValue()
		{
		}

		public void SetHasInit(bool value)
		{
		}
	}
}
