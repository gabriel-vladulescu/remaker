using System;
using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Scripts.Ssar.Arena
{
	public class PvpTestSkillContainer : MonoBehaviour
	{
		private class SeperateData
		{
			public List<ISkillStat> row1;

			public List<ISkillStat> row2;

			public List<ISkillStat> row3;
		}

		public GameObject wg_more;

		public GameObject btn_more;

		public GameObject btn_closeMore;

		public UITable table_active;

		public UITable table_signature;

		public UITable table_passive;

		public Action onEdit;

		private PvpTestActiveSkill[] activeSkills;

		private PvpTestSignatureSkill[] signatureSkillViews;

		private PvpTestPassiveSkill[] passiveSkills;

		private MainCharacterData mainCharacterData;

		private void Awake()
		{
		}

		public void Show(MainCharacterData mainCharacterData)
		{
		}

		private SeperateData SeprateSignatureSkill(List<CharacterSignatureSkillStat> characterSignatureSkillStats)
		{
			return null;
		}

		private SeperateData SeperatePassiveSkill(List<CharacterPassiveSkillStat> characterPassiveSkillStats)
		{
			return null;
		}

		private void UpdateSkill2(MainCharacterData mainCharacterData, int characterLevel, SeperateData seperateData, PvpTestSignatureSkill[] views)
		{
		}
	}
}
