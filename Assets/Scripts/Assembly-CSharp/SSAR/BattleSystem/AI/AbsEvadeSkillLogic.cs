using Artemis;
using SSAR.BattleSystem.Input;

namespace SSAR.BattleSystem.AI
{
	public abstract class AbsEvadeSkillLogic
	{
		protected Entity self;

		public AbsEvadeSkillLogic(Entity self)
		{
		}

		public abstract void OnAwake();

		public abstract void OnExcute();

		public abstract void OnExcute(float deltaTime);

		public abstract bool IsExit();

		public abstract void OnExit();

		protected ICallBack GetInput()
		{
			return null;
		}
	}
}
