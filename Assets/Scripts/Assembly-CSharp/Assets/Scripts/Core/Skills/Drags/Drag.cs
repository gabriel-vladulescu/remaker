using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Drags
{
	public class Drag
	{
		private Character caster;

		private float duration;

		private Vector2 offset;

		private float elapsed;

		private Character target;

		private MovementComponent targetMovementComponent;

		private GameObject go;

		private bool isResume;

		private float rotateZAngle;

		public Drag(Character caster, Environment environment, float duration, float radius, Vector2 offset, object entityWorld)
		{
		}

		public Drag(Character caster, float duration, Vector2 offset, Character target, object entityWorld)
		{
		}

		private void RotateZ(Transform transform, float angle)
		{
		}

		public void Update(float dt)
		{
		}

		public void Interrupt()
		{
		}

		private bool IsFinish()
		{
			return false;
		}
	}
}
