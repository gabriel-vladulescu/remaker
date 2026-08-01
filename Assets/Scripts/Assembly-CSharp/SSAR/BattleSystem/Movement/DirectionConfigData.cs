using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class DirectionConfigData : MonoBehaviour
	{
		public enum Mode
		{
			Rotation = 0,
			Flip = 1
		}

		public enum ControlType
		{
			Auto = 0,
			Force = 1
		}

		public Mode mode;

		public Direction initialDirection;

		public float baseAngleY;

		[Header("Control")]
		public ControlType controlType;

		public Direction forcedDirection;
	}
}
