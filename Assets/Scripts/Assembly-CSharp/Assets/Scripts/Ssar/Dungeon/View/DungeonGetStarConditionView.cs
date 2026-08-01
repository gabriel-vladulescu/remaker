using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class DungeonGetStarConditionView : MonoBehaviour
	{
		public UISprite sp_star;

		public UILabel lb_desc;

		public Color32 colorUnComplete;

		public Color32 colorComplete;

		public void Show(IDungeonGetStarRule rule, bool complete)
		{
		}
	}
}
