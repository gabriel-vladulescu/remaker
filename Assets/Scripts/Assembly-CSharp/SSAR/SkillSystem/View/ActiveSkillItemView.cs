using System;
using SSAR.SkillSystem.Model;
using Scripts.Config;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public class ActiveSkillItemView : MonoBehaviour
	{
		public SkillItemView SkillItemView;

		public GameObject wg_active;

		public UISprite sp_bg;

		public Action<int> OnSelect;

		public CharacterActiveSkillStat characterActiveSkillStat;

		public GameObject wgInfo;

		public GameObject wgCommingSoon;

		public GameObject wgEquipped;

		private HeroConfig heroConfig;

		private JsonEquipmentDropConfig jsonEquipmentDropConfig;

		private bool enableInfo;

		private Preset preset;

		private void Awake()
		{
		}

		public void Show(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, ActiveSkillRuneData runeData, bool enable, Preset preset)
		{
		}

		public void Hide()
		{
		}

		public void Select()
		{
		}

		public void UnSelect()
		{
		}

		public void Click(GameObject o)
		{
		}

		private bool IsEnhance(MainCharacterData mainCharacterData, CharacterActiveSkillStat characterActiveSkillStat)
		{
			return false;
		}
	}
}
