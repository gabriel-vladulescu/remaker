using UnityEngine;

namespace SSAR.BattleSystem.Gizmo
{
	public interface IShape
	{
		Vector3 GetPos();

		Color GetColor();

		void SetPos(Vector3 newPos);

		void SetRotation(Quaternion rotate);
	}
}
