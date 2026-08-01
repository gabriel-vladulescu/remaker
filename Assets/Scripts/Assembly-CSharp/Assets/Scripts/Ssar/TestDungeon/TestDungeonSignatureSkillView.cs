using System;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.TestDungeon
{
	public class TestDungeonSignatureSkillView : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_lock;

		public GameObject wg_lock;

		public UISprite sp_icon;

		public UIInput level;

		public GameObject wg_rune;

		public Action UpdateData;

		private ISkillStat skillStat;

		private void Awake()
		{
		}

		public void Show(ISkillStat activeSkillStat, int characterLevel)
		{
		}

		public void Hide()
		{
		}

		private void UpdateRune(UIInput input)
		{
		}

		protected virtual int GetMaxLevel(ISkillStat skillStat)
		{
			return 0;
		}

		protected virtual void ChangeLevel(ISkillStat skillStat, int level)
		{
		}
	}
}
