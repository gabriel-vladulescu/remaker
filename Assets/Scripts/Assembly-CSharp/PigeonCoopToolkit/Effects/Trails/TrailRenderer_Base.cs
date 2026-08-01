using System;
using System.Collections.Generic;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	public abstract class TrailRenderer_Base : MonoBehaviour
	{
		public PCTrailRendererData TrailData;

		public bool Emit;

		protected bool _emit;

		protected bool _noDecay;

		private PCTrail _activeTrail;

		private List<PCTrail> _fadingTrails;

		protected Transform _t;

		private static Dictionary<Material, List<PCTrail>> _matToTrailList;

		private static List<Mesh> _toClean;

		private static bool _hasRenderer;

		private static int GlobalTrailRendererCount;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnStopEmit()
		{
		}

		protected virtual void OnStartEmit()
		{
		}

		protected virtual void OnTranslate(Vector3 t)
		{
		}

		protected abstract int GetMaxNumberOfPoints();

		protected virtual void Reset()
		{
		}

		protected virtual void InitialiseNewPoint(PCTrailPoint newPoint)
		{
		}

		protected virtual void UpdateTrail(PCTrail trail, float deltaTime)
		{
		}

		protected void AddPoint(PCTrailPoint newPoint, Vector3 pos)
		{
		}

		private void GenerateMesh(PCTrail trail)
		{
		}

		private void DrawMesh(Mesh trailMesh, Material trailMaterial)
		{
		}

		private void UpdatePoints(PCTrail line, float deltaTime)
		{
		}

		[Obsolete("UpdatePoint is deprecated, you should instead override UpdateTrail and loop through the individual points yourself (See Smoke or Smoke Plume scripts for how to do this).", true)]
		protected virtual void UpdatePoint(PCTrailPoint pCTrailPoint, float deltaTime)
		{
		}

		private void CheckEmitChange()
		{
		}

		private int NumberOfActivePoints(PCTrail line)
		{
			return 0;
		}

		[ContextMenu("Toggle inspector size input method")]
		protected void ToggleSizeInputStyle()
		{
		}

		[ContextMenu("Toggle inspector color input method")]
		protected void ToggleColorInputStyle()
		{
		}

		public void LifeDecayEnabled(bool enabled)
		{
		}

		public void Translate(Vector3 t)
		{
		}

		public void CreateTrail(Vector3 from, Vector3 to, float distanceBetweenPoints)
		{
		}

		public void ClearSystem(bool emitState)
		{
		}

		public int NumSegments()
		{
			return 0;
		}
	}
}
