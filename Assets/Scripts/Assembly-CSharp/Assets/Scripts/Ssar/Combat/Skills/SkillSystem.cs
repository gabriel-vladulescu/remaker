using Artemis;
using Artemis.System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class SkillSystem : EntityProcessingSystemWithTime
	{
		public bool enableUpdate;

		public SkillSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		public override void Process()
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}
	}
}
