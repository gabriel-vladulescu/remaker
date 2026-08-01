using UnityEngine;

namespace MaterialMontion
{
	[AddComponentMenu("Mesh/ShiftUV")]
	[RequireComponent(typeof(MeshFilter))]
	public class ShiftUV : MonoBehaviour
	{
		[SerializeField]
		private bool random_U;

		[SerializeField]
		private bool random_V;

		[SerializeField]
		private float U_Offset;

		[SerializeField]
		private float V_Offset;

		private void Awake()
		{
		}
	}
}
