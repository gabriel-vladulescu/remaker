using Artemis;
using Artemis.Interface;

namespace SSAR.BattleSystem.AI
{
	public class OnEntitySpawnTrigger : AbsTrigger
	{
		public int entityGroupId;

		public float pointDeduct;

		public OnEntitySpawnTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		private void OnSpawnEntity(Entity entity, IComponent component)
		{
		}

		public override void OnRemove()
		{
		}

		public override bool IsTrigger()
		{
			return false;
		}

		public override void OnTrigger(float deltaTime, ref float point)
		{
		}
	}
}
