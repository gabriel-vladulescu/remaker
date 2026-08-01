using System.Collections.Generic;
using UnityEngine;

namespace SSAR.Dungeon.Caching
{
	public class DefaultRenderMaterialControl : IRenderMaterialControl
	{
		private Renderer[] renderer;

		private Material[] m_materials;

		private Dictionary<Renderer, List<Material>> cache;

		public DefaultRenderMaterialControl(Renderer[] renderer)
		{
		}

		public Material[] GetMaterials(bool updateWeapon = false)
		{
			return null;
		}

		public void UpdateListMaterial(bool updateWeapon = false)
		{
		}

		public void SetMaterials(Material[] materials, bool updateWeapon = false)
		{
		}
	}
}
