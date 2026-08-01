using UnityEngine;

namespace SSAR.Equipment.View
{
	public class CharacterSimpleStatView : MonoBehaviour
	{
		public UILabel lb_level;

		public UILabel lb_progress;

		public UILabel lb_name;

		public UILabel lb_combatPower;

		public UILabel lb_surrvivability;

		public UILabel lb_hp;

		public UILabel lb_attackTitle;

		public UILabel lb_defenseTitle;

		public UILabel lb_hpTitle;

		public UILabel lb_playingTime;

		public UIProgressBar expBar;

		public UILabel lb_masteryLv;

		private void Awake()
		{
		}

		public void UpdateData(MainCharacterData mainCharacter, bool isCurrentUser = true)
		{
		}
	}
}
