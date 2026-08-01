using UnityEngine;

namespace Assets.Scripts.Ssar.Common.Pooling
{
	public class GameObjectItem : MonoBehaviour, Item
	{
		private string goName;

		public virtual bool IsActive()
		{
			return false;
		}

		public virtual void OnObtain()
		{
		}

		public virtual void OnReturn()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
