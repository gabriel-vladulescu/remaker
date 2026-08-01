using UnityEngine;

namespace Assets.Scripts.Utils
{
	[RequireComponent(typeof(Animation))]
	public class AnimationSpeedControl : MonoBehaviour
	{
		public float speed;

		private void Awake()
		{
		}
	}
}
