using Spine.Unity;
using Spine.Unity.Modules;
using UnityEngine;

namespace SSAR.Dungeon.Caching
{
	public class SpineRenderMaterialControl : IRenderMaterialControl
	{
		private SkeletonAnimation skeletonAnimation;

		private Renderer renderer;

		private SkeletonRendererCustomMaterials customMaterials;

		private bool hasSetCustomMaterial;

		public SpineRenderMaterialControl(Renderer renderer, SkeletonAnimation skeletonAnimation)
		{
		}

		public Material[] GetMaterials(bool updateWeapon = false)
		{
			return null;
		}

		public void SetMaterials(Material[] materials, bool updateWeapon = false)
		{
		}

		public void UpdateListMaterial(bool updateWeapon = false)
		{
		}
	}
}
