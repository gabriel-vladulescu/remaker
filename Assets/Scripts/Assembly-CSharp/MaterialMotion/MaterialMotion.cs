using System.Collections.Generic;
using UnityEngine;

namespace MaterialMotion
{
	[AddComponentMenu("Miscellaneous/MaterialMotion")]
	[ExecuteInEditMode]
	public class MaterialMotion : MonoBehaviour
	{
		public bool mUpdate;

		public List<MotionLayer> mLayers;

		[SerializeField]
		private List<List<MotionLayer>> mMapping;

		private int mMaterialCount;

		public void AddLayer()
		{
		}

		public void RemoveLayer(MotionLayer pLayer)
		{
		}

		public void RemoveLayer(int pIndex)
		{
		}

		public void UpdateMapping()
		{
		}

		private void UpdateMaterials()
		{
		}

		private void UpdateColor(List<MotionLayer> pMotionLayers, ref Material pMaterial)
		{
		}

		private void UpdateFloat(List<MotionLayer> pMotionLayers, ref Material pMaterial)
		{
		}

		private void UpdateTexEnv(List<MotionLayer> pMotionLayers, ref Material pMaterial)
		{
		}

		private bool ValidateMaterialIndices()
		{
			return false;
		}

		private Vector2 WrapVector2(ref Vector2 pVector)
		{
			return default(Vector2);
		}

		public void Start()
		{
		}

		private void Reset()
		{
		}

		public void Update()
		{
		}
	}
}
