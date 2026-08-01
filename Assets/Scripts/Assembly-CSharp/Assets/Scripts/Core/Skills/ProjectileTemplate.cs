using Artemis;
using Artemis.Interface;

namespace Assets.Scripts.Core.Skills
{
	internal class ProjectileTemplate : IEntityTemplate
	{
		public const string Name = "Projectile";

		public Entity BuildEntity(Entity entity, EntityWorld entityWorld, params object[] args)
		{
			return null;
		}
	}
}
