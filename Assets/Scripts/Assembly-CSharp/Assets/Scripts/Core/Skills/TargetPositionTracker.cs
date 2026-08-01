using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class TargetPositionTracker
	{
		private const int history_size = 300;

		private Character target;

		private float elapsed;

		private Dictionary<int, Vector3> positionsByFrames;

		public void Update(float dt)
		{
		}

		public void StartTracking(Character target)
		{
		}

		public Vector3 PositionAt(int frame)
		{
			return default(Vector3);
		}
	}
}
