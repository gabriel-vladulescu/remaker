using Assets.Scripts.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class EquipmentView : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_leftTop;

		public UILabel lb_rightTop;

		public UILabel lb_tier;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_tier;

		public UITable table_rune;

		public UISprite[] skillIcon;

		public GameObject icon_lock;

		public GameObject wg_inUse;

		private IItem iItem;

		private AwakenLevelView awakenLevelView;

		protected virtual void Awake()
		{
		}

		public void SetActiveWgInUse(bool active)
		{
		}

		public virtual void Show(IItem iItem)
		{
		}

		public void Hide()
		{
		}
	}
}
