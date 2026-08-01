using UnityEngine;

namespace Spine.Unity
{
	public class MeshRendererBuffers
	{
		public class SmartMesh
		{
			public Mesh mesh = new Mesh();

			public SkeletonRendererInstruction instructionUsed = new SkeletonRendererInstruction();
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public SmartMesh GetNextMesh()
		{
			return null;
		}

		public void UpdateSharedMaterials(ExposedList<SubmeshInstruction> instructions)
		{
		}

		public Material[] GetUpdatedSharedMaterialsArray()
		{
			return null;
		}

		public bool MaterialsChangedInLastUpdate()
		{
			return false;
		}
	}
}
