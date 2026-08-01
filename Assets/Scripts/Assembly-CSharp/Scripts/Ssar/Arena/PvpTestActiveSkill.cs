using System;
using SSAR.SkillSystem.Utils;
using Scripts.Config;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class PvpTestActiveSkill : MonoBehaviour
	{
		public UILabel lb_order;

		public UILabel lb_name;

		public UILabel lb_lock;

		public GameObject wg_lock;

		public UISprite sp_icon;

		public UIInput powerLevel;

		public UIInput arcaneLevel;

		public UIInput tacticLevel;

		public UIInput order;

		public GameObject wg_rune;

		public Action UpdateData;

		private CharacterActiveSkillStat activeSkillStat;

		private MainCharacterData mainCharacterData;

		private void Awake()
		{
		}

		public void Show(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, int characterLevel)
		{
		}

		public void Hide()
		{
		}

		public void UpdateAllRune()
		{
		}

		public void UpdateOrder()
		{
		}

		private void UpdateRune(UIInput input, SSAR.SkillSystem.Utils.RuneType runeType)
		{
		}
	}
}
