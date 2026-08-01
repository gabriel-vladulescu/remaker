using UnityEngine;

namespace SSAR.View
{
	public abstract class AbsButtonNofity : MonoBehaviour
	{
		private const float DELAY = 0.1f;

		public GameObject icon_notify;

		public GameObject incon_not_notify;

		private float time;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnEnable()
		{
		}

		protected virtual void Update()
		{
		}

		protected abstract bool IsNotify();

		protected virtual void CheckIconNotify()
		{
		}

		protected virtual void onEnable()
		{
		}
	}
}
