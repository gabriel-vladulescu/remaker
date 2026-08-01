using SSAR.BattleSystem.Input;

namespace Scripts.Ssar.Arena
{
	public class InputData
	{
		public interface ParseParameter
		{
			AbsInputParameter Generate();
		}

		public class DefaultParameter : ParseParameter
		{
			public int entityId { get; set; }

			public DefaultParameter()
			{
			}

			public DefaultParameter(AbsInputParameter absInputParameter)
			{
			}

			public AbsInputParameter Generate()
			{
				return null;
			}
		}

		public class JoyStickParameter : ParseParameter
		{
			public double vectorX;

			public double vectorY;

			public bool changeFaceDirection;

			public int entityId;

			public JoyStickParameter()
			{
			}

			public JoyStickParameter(JoyStickMoveParameter absInputParameter)
			{
			}

			public AbsInputParameter Generate()
			{
				return null;
			}
		}

		public int frame;

		public ActionType ActionType;

		public string parameter;

		public InputData(int frame, ActionType actionType, AbsInputParameter absInputParameter)
		{
		}

		public InputData()
		{
		}

		public AbsInputParameter GetInputParameter()
		{
			return null;
		}
	}
}
