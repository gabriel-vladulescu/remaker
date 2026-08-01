using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.System.Collision;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class DefaultCollision : Assets.Scripts.Core.Skills.Collision
	{
		private class DefaultObstacle : Obstacle
		{
			private UnityEngine.Collider collider;

			public DefaultObstacle(UnityEngine.Collider collider)
			{
			}

			public string Name()
			{
				return null;
			}
		}

		public List<Character> FindCharactersCollideWith(Assets.Scripts.Core.Skills.Collider collider)
		{
			return null;
		}

		public List<Obstacle> FindObstaclesCollideWith(Assets.Scripts.Core.Skills.Collider collider)
		{
			return null;
		}

		private static ICollider CreateCollider(Assets.Scripts.Core.Skills.Collider collider)
		{
			return null;
		}
	}
}
