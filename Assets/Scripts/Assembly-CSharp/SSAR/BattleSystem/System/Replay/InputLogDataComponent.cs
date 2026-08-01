using System.Collections.Generic;
using Artemis.Interface;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Input;
using Scripts.Ssar.Arena;

namespace SSAR.BattleSystem.System.Replay
{
	public class InputLogDataComponent : IComponent
	{
		private Dictionary<string, List<InputData>> inputs;

		private UniversalInputSystem dungeonSystem;

		private bool isReplay;

		public bool enable;

		private const string FRAME = "frame_";

		private void Listener(int id, float damage, DamageSource damageSource)
		{
		}

		public void SetInput(Dictionary<string, List<InputData>> inputLog)
		{
		}

		public Dictionary<string, List<InputData>> GetInputLog()
		{
			return null;
		}

		public void Input(int frame, ActionType actionType, AbsInputParameter parameter)
		{
		}

		private UniversalInputSystem GetDungeonSys()
		{
			return null;
		}
	}
}
