using System.Collections.Generic;
using Artemis.Interface;

namespace SSAR.BattleSystem.Gizmo
{
	public class GizmoRendererComponent : IComponent
	{
		public List<GizmoDrawRequest> requests;

		public UnityGizmoRendererComponent renderer;

		public void Render()
		{
		}
	}
}
