using System;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.CharacterSelection.View
{
	public class CharacterInfoSkillView : MonoBehaviour
	{
		public UISprite sp_bg;

		public UISprite sp_icon;

		public UISprite sp_selected;

		public Action<CharacterActiveSkillStat> onSelect;

		private CharacterActiveSkillStat activeSkillStat;

		private void Awake()
		{
		}

		public void Click(GameObject go)
		{
		}

		public void Show(CharacterActiveSkillStat activeSkillStat, bool available)
		{
		}

		public void Hide()
		{
		}

		public void Selected()
		{
		}

		public void UnSelect()
		{
		}

		public bool IsSelected(CharacterActiveSkillStat activeSkillStat)
		{
			return false;
		}
	}
}
