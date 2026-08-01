using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public class ActiveSkillPointContainer : MonoBehaviour
	{
		public UILabel lb_currentPoint;

		public UILabel lb_normalPoint;

		public UILabel lb_purchasePoint;

		private Preset preset;

		public void Show(MainCharacterData mainCharacterData, Preset preset)
		{
		}
	}
}
