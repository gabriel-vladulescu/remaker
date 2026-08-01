using System;
using SSAR.SkillSystem.Utils;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.TestDungeon
{
	public class TestDungeonActiveSkill : MonoBehaviour
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

		public Action updateRune;

		public Action updateOrder;

		private CharacterActiveSkillStat activeSkillStat;

		private void Awake()
		{
		}

		public void Show(CharacterActiveSkillStat activeSkillStat, int characterLevel)
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

		private void UpdateRune(UIInput input, RuneType runeType)
		{
		}
	}
}
