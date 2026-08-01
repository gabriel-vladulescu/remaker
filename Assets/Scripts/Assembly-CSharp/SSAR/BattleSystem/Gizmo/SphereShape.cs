using UnityEngine;

namespace SSAR.BattleSystem.Gizmo
{
	public class SphereShape : IShape
	{
		public float radius;

		private Vector3 pos;

		private Color color;

		private int hitboxId;

		public int HitboxId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public SphereShape(Vector3 pos, float radius)
		{
		}

		public SphereShape(Vector3 pos, float radius, Color color)
		{
		}

		public SphereShape(Vector3 pos, Vector3 size, Color color)
		{
		}

		public Vector3 GetPos()
		{
			return default(Vector3);
		}

		public Color GetColor()
		{
			return default(Color);
		}

		public void SetPos(Vector3 newPos)
		{
		}

		public void SetRotation(Quaternion rotate)
		{
		}
	}
}
