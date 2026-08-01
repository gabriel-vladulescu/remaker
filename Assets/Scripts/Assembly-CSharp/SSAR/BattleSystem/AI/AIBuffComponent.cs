using System.Collections.Generic;
using Artemis.Interface;

namespace SSAR.BattleSystem.AI
{
	public class AIBuffComponent : IComponent
	{
		private List<AbsAIBuff> buffs;

		public void Update(float deltaTime)
		{
		}

		public void AddBuff(AbsAIBuff buff)
		{
		}

		private void RemoveBuff(AbsAIBuff buff)
		{
		}

		public void ClearAllBuff()
		{
		}
	}
}
