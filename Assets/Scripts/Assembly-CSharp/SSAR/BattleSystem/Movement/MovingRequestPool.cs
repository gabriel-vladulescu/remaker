using System.Collections.Generic;

namespace SSAR.BattleSystem.Movement
{
	public class MovingRequestPool
	{
		private static MovingRequestPool _instance;

		private Stack<AbsRequest> pool;

		public static MovingRequestPool Instance => null;

		private MovingRequestPool()
		{
		}

		public void DeleteRequest(AbsRequest request)
		{
		}
	}
}
