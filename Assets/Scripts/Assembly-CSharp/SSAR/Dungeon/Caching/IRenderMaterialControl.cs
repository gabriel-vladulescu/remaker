using UnityEngine;

namespace SSAR.Dungeon.Caching
{
	public interface IRenderMaterialControl
	{
		Material[] GetMaterials(bool updateWeapon = false);

		void SetMaterials(Material[] materials, bool updateWeapon = false);

		void UpdateListMaterial(bool updateWeapon = false);
	}
}
