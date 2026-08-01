using System;

namespace Artemis.System
{
	public abstract class EntitySystemWithTime : EntitySystem
	{
		public override void Process()
		{
			if (CheckProcessing())
			{
				Begin();
				float deltaTime = (float)entityWorld.Delta / TimeSpan.TicksPerSecond;
				Process(deltaTime);
				End();
			}
		}

		protected abstract void Process(float deltaTime);
	}
}
