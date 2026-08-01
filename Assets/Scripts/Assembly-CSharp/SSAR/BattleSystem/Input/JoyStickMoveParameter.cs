using UnityEngine;

namespace SSAR.BattleSystem.Input
{
	public class JoyStickMoveParameter : AbsInputParameter
	{
		public Vector2 dir;

		public bool changeFaceDirection;

		public JoyStickMoveParameter(int entityId, Vector2 dir, bool changeFace)
			: base(0)
		{
		}

		public JoyStickMoveParameter()
			: base(0)
		{
		}
	}
}
