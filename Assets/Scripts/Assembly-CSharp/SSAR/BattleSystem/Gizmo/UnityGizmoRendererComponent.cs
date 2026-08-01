using System;
using System.Collections.Generic;
using UnityEngine;

namespace SSAR.BattleSystem.Gizmo
{
	public class UnityGizmoRendererComponent : MonoBehaviour
	{
		private List<IShape> shapes;

		private Dictionary<Type, IShapeRenderer> supportedRenderers;

		private void Start()
		{
		}

		public void SubmitDraw(List<IShape> shapes)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
