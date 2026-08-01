using UnityEngine;

namespace SSAR.BattleSystem.Gizmo
{
	public class CubeShape : IShape
	{
		public Vector3 size;

		private Vector3 pos;

		private Color color;

		private Quaternion rotate;

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

		public CubeShape(Vector3 pos, Vector3 size)
		{
		}

		public CubeShape(Vector3 pos, Vector3 size, Color color)
		{
		}

		public CubeShape(Vector3 pos, Vector3 size, Color color, Quaternion rotate)
		{
		}

		public CubeShape SetRotate(Quaternion rotate)
		{
			return null;
		}

		public CubeShape SetColor(Color color)
		{
			return null;
		}

		public Quaternion GetRotate()
		{
			return default(Quaternion);
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

		public void SetSize(Vector2 size)
		{
		}
	}
}
