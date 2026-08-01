using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Core.Skills
{
	public class ProjectileTrajectoryParams
	{
		private readonly ProjectileTrajectoryType type;

		private readonly ITrajectoryConfig config;

		public ProjectileTrajectoryType Type => default(ProjectileTrajectoryType);

		public ITrajectoryConfig Config => null;

		public ProjectileTrajectoryParams(ProjectileTrajectoryType type, ITrajectoryConfig config)
		{
		}

		public bool IsDefaultTrajectory()
		{
			return false;
		}
	}
}
