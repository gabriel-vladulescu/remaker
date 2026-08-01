using UnityEngine;

namespace SSAR.BattleSystem.Gizmo
{
	public class LineShape : IShape
	{
		private readonly Vector3 from;

		private readonly Vector3 to;

		private Color color;

		public LineShape(Vector3 from, Vector3 to)
		{
		}

		public LineShape SetColor(Color color)
		{
			return null;
		}

		public Vector3 GetPos()
		{
			return default(Vector3);
		}

		public Vector3 To()
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
