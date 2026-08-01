using UnityEngine;

namespace Spine.Unity
{
	public struct SubmeshInstruction
	{
		public Skeleton skeleton;

		public Material material;

		public int startSlot;

		public int endSlot;

		public bool forceSeparate;

		public int preferredVertexCount;

		public bool hasClipping;
	}
}
