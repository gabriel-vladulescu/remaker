using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Teleports
{
	public class Teleport
	{
		private EventFrame ef;

		private Character caster;

		private Environment environment;

		private float elapsed;

		private bool notificationPlayed;

		private bool targetTracked;

		private bool isAppear;

		private Vector3 trackedPosition;

		private float mostLeftX;

		private float mostRightX;

		public EventFrame EventFrame => null;

		public Teleport(EventFrame ef, Character caster, Environment environment)
		{
		}

		public void Update(float dt)
		{
		}

		public void PerformTeleport()
		{
		}

		private void TeleportAction()
		{
		}

		private Character GetTarget()
		{
			return null;
		}

		private Vector3 GetTargetPosition(Character target)
		{
			return default(Vector3);
		}

		private Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		private Vector3 GetRandomPositionAroundTarget()
		{
			return default(Vector3);
		}

		private Direction GetTargetFacingDirection(Character target)
		{
			return default(Direction);
		}

		private bool IsTeleportToLeftSide(float leftLength, float rightLength, Direction targetFacingDirection, Vector3 targetPos)
		{
			return false;
		}
	}
}
