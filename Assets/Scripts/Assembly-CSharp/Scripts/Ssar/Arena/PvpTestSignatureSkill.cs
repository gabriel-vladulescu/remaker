using System;
using Scripts.Config;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class PvpTestSignatureSkill : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_lock;

		public GameObject wg_lock;

		public UISprite sp_icon;

		public UIInput level;

		public GameObject wg_rune;

		public Action UpdateData;

		private ISkillStat skillStat;

		protected MainCharacterData mainCharacterData;

		private void Awake()
		{
		}

		public void Show(MainCharacterData mainCharacterData, ISkillStat activeSkillStat, int characterLevel)
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
