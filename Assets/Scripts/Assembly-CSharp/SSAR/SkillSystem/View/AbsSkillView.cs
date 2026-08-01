using System;
using Scripts.Config;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public abstract class AbsSkillView : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_level;

		public UILabel lb_unlockLevel;

		public UISprite sp_icon;

		public GameObject btn_plus;

		public GameObject btn_minus;

		public GameObject wg_click;

		public GameObject wg_select;

		public GameObject wg_lock;

		public GameObject wg_level;

		public TweenScale TweenScale;

		public Action<int> OnSelect;

		public ISkillStat skillStat;

		private MainCharacterData mainCharacterData;

		private int level;

		private int maxLevel;

		private bool unlock;

		private GameObject fx;

		private bool hasSelect;

		private bool allowEdit;

		private ParticleRunAroundFx particleRunAroundFx;

		private Preset preset;

		private Material grayScaleMaterial;

		private void Awake()
		{
		}

		public void Init()
		{
		}

		private void InitFx()
		{
		}

		public void Show(MainCharacterData mainCharacterData, ISkillStat characterSignatureSkillStat, bool allowEdit, Preset preset)
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

		private void Invest(GameObject o)
		{
		}

		private void Divest(GameObject o)
		{
		}

		private void PlayFx()
		{
		}

		protected abstract int GetCurrentLevel(MainCharacterData mainCharacterData, ISkillStat skillStat, Preset preset);

		protected abstract int GetMaxLevel(ISkillStat skillStat);

		protected abstract string GetNameLocalize(ISkillStat skillStat);

		protected abstract void GetIcon(ISkillStat skillStat, ref UISprite sp_icon);

		protected abstract void Invest(MainCharacterData mainCharacterData, ISkillStat skillStat, Preset preset);

		protected abstract void Divest(ISkillStat skillStat, Preset preset);
	}
}
