using System;

namespace Artemis.System
{
	public abstract class EntityProcessingSystemWithTime : EntitySystem
	{
		private readonly bool subscribeSimTime;

		private float deltaTime;

		protected EntityProcessingSystemWithTime(Aspect aspect, bool subscribeSimTime)
			: base(aspect)
		{
			this.subscribeSimTime = subscribeSimTime;
		}

		protected abstract void Process(Entity entity, float deltaTime);

		public override void Process()
		{
			if (CheckProcessing())
			{
				Begin();
				deltaTime = (float)entityWorld.Delta / TimeSpan.TicksPerSecond;
				foreach (Entity entity in ActiveEntities)
				{
					Process(entity, deltaTime);
				}
				End();
			}
		}
	}
}
