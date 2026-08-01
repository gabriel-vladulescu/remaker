namespace Assets.Scripts.Ssar.Tutorial
{
	public class NpcRequest
	{
		public TutorialNpc npc;

		public Position initPosition;

		public Position startPosition;

		public Position endPosition;

		public NpcFace startFace;

		public NpcFace faceAfterFinishMoveWhenStart;

		public bool enableInit;

		public NpcRequest(TutorialNpc npc)
		{
		}

		public NpcRequest LeftScreen()
		{
			return null;
		}

		public NpcRequest RightScreen()
		{
			return null;
		}

		public NpcRequest SetInitPosition(Position position)
		{
			return null;
		}

		public NpcRequest SetStartPosition(Position position)
		{
			return null;
		}

		public NpcRequest SetEndPosition(Position position)
		{
			return null;
		}

		public NpcRequest SetStartFace(NpcFace face)
		{
			return null;
		}

		public NpcRequest SetFaceAfterMoveWhenStart(NpcFace face)
		{
			return null;
		}

		public NpcRequest DisableInitModel()
		{
			return null;
		}
	}
}
