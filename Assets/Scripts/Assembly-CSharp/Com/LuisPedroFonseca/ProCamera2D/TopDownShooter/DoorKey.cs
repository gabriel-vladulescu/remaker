using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
	public class DoorKey : MonoBehaviour
	{
		public Door Door;

		public string PickupTag;

		public ProCamera2DCinematics Cinematics;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
