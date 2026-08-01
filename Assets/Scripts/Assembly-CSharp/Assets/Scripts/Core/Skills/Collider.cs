using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public interface Collider
	{
		Vector3 RelativePositionToCharacter();

		void SetWorldPosition(Vector3 worldPos);

		Vector3 WorldPosition();

		Vector2 Dimension();

		float Radius();

		float RelativeEulerAngle();

		Quaternion WorldRotation();

		void SetWorldRotation(float angle);

		ColliderShape Shape();
	}
}
