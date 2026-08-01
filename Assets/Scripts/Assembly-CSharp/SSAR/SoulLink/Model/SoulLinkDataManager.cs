using System.Collections.Generic;
using Assets.Scripts.Ssar.CharacterSelection.Model;
using Scripts.Config;

namespace Ssar.SoulLink.Model
{
	public class SoulLinkDataManager
	{
		private class CharacterStatus
		{
			public int power;

			public int level;

			public CharacterStatus(int power, int level)
			{
			}
		}

		private Dictionary<int, CharacterStatus> characterStatuses;

		private CharacterCode curCharacterCode;

		public void UpdateCharacterStatus(MainCharacterData mainCharacterData)
		{
		}

		public float GetBonus(SoulLinkConfig.BonusType bonusType)
		{
			return 0f;
		}

		public SoulLinkConfig.Milestone GetNextMilestone(SoulLinkConfig.BonusType bonusType)
		{
			return null;
		}

		public void SetCurrentCharacter(CharacterCode characterCode)
		{
		}

		public CharacterCode GetCurrentCharacter()
		{
			return default(CharacterCode);
		}

		public void ResetCurrentCharacter()
		{
		}

		private CharacterStatus GetCharacterStatus(int characterId)
		{
			return null;
		}
	}
}
