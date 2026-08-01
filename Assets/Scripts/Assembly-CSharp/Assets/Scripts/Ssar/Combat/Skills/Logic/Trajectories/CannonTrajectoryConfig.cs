using Assets.Scripts.Core.Skills.Projectiles;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trajectories
{
	public class CannonTrajectoryConfig : ITrajectoryConfig
	{
		public float initialSpeed;

		public Vector2 direction;

		public float gravity;
	}
}
