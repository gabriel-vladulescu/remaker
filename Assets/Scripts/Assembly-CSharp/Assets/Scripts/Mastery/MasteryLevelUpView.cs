using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class MasteryLevelUpView : MonoBehaviour
	{
		public UILabel lb_currentLevel;

		public UILabel lb_nextLevel;

		public UISprite sp_rune;

		public UILabel lb_soulRequire;

		public UILabel lb_runeRequire;

		public UITable table;

		public GameObject btn_trainAll;

		public GameObject btn_train;

		public GameObject btn_gotoShop;

		private MasteryInfo masteryInfo;

		private void Awake()
		{
		}

		private void OpenShop(GameObject go)
		{
		}

		private void TrainAll(GameObject go)
		{
		}

		private void Train(GameObject go)
		{
		}

		public void UpdateData(MasteryInfo masteryInfo)
		{
		}

		private int CurrentLevel()
		{
			return 0;
		}
	}
}
