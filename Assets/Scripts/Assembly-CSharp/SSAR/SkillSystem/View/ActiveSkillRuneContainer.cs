using SSAR.SkillSystem.Utils;
using Scripts.Config;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public class ActiveSkillRuneContainer : MonoBehaviour
	{
		public ActiveSkillRuneView powerRune;

		public ActiveSkillRuneView arcaneRune;

		public ActiveSkillRuneView tacticRune;

		public UILabel lb_currentLevelDesc;

		public UILabel lb_nextLevelDesc;

		private MainCharacterData mainCharacterData;

		private CharacterActiveSkillStat characterActiveSkillStat;

		private RuneType currentRuneSelect;

		private Preset preset;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void Show(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, bool allowEdit, Preset preset)
		{
		}

		private void ClickRun(RuneType runeType)
		{
		}

		private void UpdateDescription(RuneType runeType, Preset preset)
		{
		}

		private string ParseValueToString(RuneType runeType, double value)
		{
			return null;
		}
	}
}
