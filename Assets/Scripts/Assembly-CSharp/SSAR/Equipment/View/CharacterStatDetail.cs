using System.Collections.Generic;
using SSAR.Equipment.Enum;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class CharacterStatDetail : strange.extensions.mediation.impl.View
	{
		public UITable table_offense;

		public UITable table_defense;

		public UITable table_tactic;

		public UITable table_survivability;

		public GameObject btn_detail;

		public GameObject soulLinkDesc;

		private Dictionary<StatType, CharacterStatDetailRowView> subStas;

		protected override void Awake()
		{
		}

		public void Show()
		{
		}

		public void UpdateData(MainCharacterData mainCharacterData2 = null)
		{
		}

		public void Hide()
		{
		}

		private void HideDetail(GameObject o)
		{
		}

		private void Init()
		{
		}

		private void ShowStat(StatType statType, double value)
		{
		}

		private void InitOffense()
		{
		}

		private void InitDefense()
		{
		}

		private void InitTactic()
		{
		}

		private void InitSurvivability()
		{
		}

		private void AddStat(UITable parent, StatType statType, int width, bool hasColor = false)
		{
		}
	}
}
