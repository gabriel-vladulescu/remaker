using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Common.System
{
	public class DefaultSystem
	{
		private List<SubSystem> subSystems;

		public void AddSubSystem(SubSystem subSystem)
		{
		}

		public void StartUp()
		{
		}

		public void ShutDown()
		{
		}

		public T GetSubSystem<T>() where T : SubSystem
		{
			return default(T);
		}
	}
}
