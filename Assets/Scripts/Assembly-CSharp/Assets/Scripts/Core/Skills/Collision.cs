using System.Collections.Generic;

namespace Assets.Scripts.Core.Skills
{
	public interface Collision
	{
		List<Character> FindCharactersCollideWith(Collider collider);

		List<Obstacle> FindObstaclesCollideWith(Collider collider);
	}
}
