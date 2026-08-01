using System;
using SSAR.SkillSystem.Utils;
using Scripts.Config;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public class ActiveSkillRuneView : MonoBehaviour
	{
		public RuneType type;

		public UILabel lb_name;

		public UILabel lb_levelProgress;

		public UISprite sp_icon;

		public GameObject btn_plus;

		public GameObject btn_minus;

		public GameObject wg_click;

		public GameObject wg_select;

		public TweenScale TweenScale;

		public UITable table;

		public Action<RuneType> OnSelect;

		private int runeLevel;

		private int maxLevel;

		private bool unlock;

		private CharacterActiveSkillStat characterActiveSkillStat;

		private MainCharacterData mainCharacterData;

		private GameObject fx;

		private bool hasSelect;

		private bool allowEdit;

		private ParticleRunAroundFx particleRunAroundFx;

		private Preset preset;

		private void Awake()
		{
		}

		private void InitFx()
		{
		}

		public void Show(MainCharacterData mainCharacterData, CharacterActiveSkillStat characterActiveSkillStat, int runeLevel, int maxLevel, bool unLock, Preset preset)
		{
		}

		public void Select()
		{
		}

		public void SetAllowEdit(bool allowEdit)
		{
		}

		public void UnSelect()
		{
		}

		public void Click(GameObject o)
		{
		}

		private string GetName()
		{
			return null;
		}

		private string GetIcon()
		{
			return null;
		}

		private void Invest(GameObject o)
		{
		}

		private void Divest(GameObject o)
		{
		}

		private void PlayFx()
		{
		}
	}
}
