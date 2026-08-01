namespace SSAR.BattleSystem.Input
{
	public abstract class AbsInputParameter
	{
		public readonly int entityId;

		private int bufferFrames;

		public AbsInputParameter(int entityId)
		{
		}

		public AbsInputParameter()
		{
		}

		protected AbsInputParameter(int entityId, int bufferFrames)
		{
		}

		public bool IsBuffer()
		{
			return false;
		}

		public void CountBuffer()
		{
		}
	}
}
