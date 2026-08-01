using System;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

namespace SSAR.BattleSystem.Camera
{
	public class CinematicTargetData
	{
		public Vector3 TargetPos;

		public float EaseInDuration;

		public float HoldDuration;

		public float Zoom;

		public EaseType EaseType;

		public Action onReached;

		public Action OnLeftTarget;

		private GameObject o;

		public GameObject O => null;

		public CinematicTargetData(Vector3 targetPos, float easeInDuration = 1f, float holdDuration = 1f, float zoom = 1f, EaseType easeType = EaseType.EaseOut, Action onReached = null, Action onLeftTarget = null)
		{
		}

		public CinematicTarget ParseToCinematicTarget()
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
