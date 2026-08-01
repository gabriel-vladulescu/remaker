using Artemis;
using Artemis.Attributes;
using Artemis.Interface;

namespace Assets.Scripts.Ssar.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("Hero")]
	public class DropItemTemplate : IEntityTemplate
	{
		public const string Name = "Hero";

		public Entity BuildEntity(Entity entity, EntityWorld entityWorld, params object[] args)
		{
			return null;
		}

		protected void Base(Entity entity, params object[] args)
		{
		}
	}
}
