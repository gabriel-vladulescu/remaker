using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.CharacterSelection.View
{
	public class CharacterInfo : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_desc;

		public UILabel lb_skill;

		public UILabel lb_skillDesc;

		public UILabel lb_soulLinkDesc;

		public CharacterInfoSkillView[] SkillViews;

		public GameObject soulLinkContainer;

		private void Awake()
		{
		}

		private void OnSelect(CharacterActiveSkillStat obj)
		{
		}

		public void Show(int groupId, int subId, List<CharacterActiveSkillStat> activeSkillStats, List<bool> available, MainCharacterData mainCharacterData = null)
		{
		}

		private string GetSkillName(CharacterActiveSkillStat obj)
		{
			return null;
		}

		private string GetSkillDesc(CharacterActiveSkillStat obj)
		{
			return null;
		}

		private string GetSoulLinkDesc(int groupId, MainCharacterData mainCharacterData = null)
		{
			return null;
		}
	}
}
