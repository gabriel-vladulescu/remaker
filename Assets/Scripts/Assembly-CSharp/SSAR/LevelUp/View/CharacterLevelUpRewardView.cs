using UnityEngine;

namespace SSAR.LevelUp.View
{
	public class CharacterLevelUpRewardView : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_quantity;

		public virtual void Show(ItemInfo itemInfo)
		{
		}

		public void Hide()
		{
		}
	}
}
