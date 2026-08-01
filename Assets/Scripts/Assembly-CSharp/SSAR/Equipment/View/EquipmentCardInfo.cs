using SSAR.Equipment.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentCardInfo : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_tier;

		private AwakenLevelView awakenLevelView;

		private void Awake()
		{
		}

		public void Show(EquipmentCollectData equipmentCollectData)
		{
		}
	}
}
