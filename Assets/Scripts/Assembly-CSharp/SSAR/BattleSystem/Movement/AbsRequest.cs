using Artemis;

namespace SSAR.BattleSystem.Movement
{
	public abstract class AbsRequest
	{
		protected Entity self;

		public AccessLevel AccessLevel { get; private set; }

		public AbsRequest(AccessLevel accessLevel)
		{
			AccessLevel = accessLevel;
		}

		public void Attach(Entity self)
		{
			this.self = self;
		}

		public abstract void OnAttach();

		public abstract void Update(float deltaTime);

		public abstract bool Expired();

		public abstract void Exit();

		public abstract int Priority();

		public virtual bool InfluenceByEnvironment()
		{
			return false;
		}
	}
}
