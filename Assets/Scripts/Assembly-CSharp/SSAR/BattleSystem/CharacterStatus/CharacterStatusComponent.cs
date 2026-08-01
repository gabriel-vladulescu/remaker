using System.Collections.Generic;
using Artemis.Interface;

namespace SSAR.BattleSystem.CharacterStatus
{
	public class CharacterStatusComponent : IComponent
	{
		public ICharacterStatus CurStatus;

		private Dictionary<Status, float> priority;

		public void ChangeStatus(ICharacterStatus status)
		{
		}

		public bool IsInvulnerable()
		{
			return false;
		}

		public bool AvailableChangeStatus(ICharacterStatus status)
		{
			return false;
		}

		private void InitPriority()
		{
		}

		private float GetPriority(Status status)
		{
			return 0f;
		}
	}
}
