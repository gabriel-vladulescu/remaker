using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class MaterialConfig : MonoBehaviour
	{
		[HideInInspector]
		public string originalMaterialPath;

		[HideInInspector]
		public string cursedMaterialPath;

		[HideInInspector]
		public string freezeMaterialPath;

		private Material originalWeaponMaterial;

		private Material originalBodyMaterial;

		private Material originalHeadMaterial;

		private SkinnedMeshRenderer bodyRenderer;

		private SkinnedMeshRenderer headRenderer;

		private SkinnedMeshRenderer weaponRenderer;

		private string baseTextureProperty;

		public void ChangeMaterialToCursed()
		{
		}

		public void ChangeMaterialToFreeze()
		{
		}

		public void ChangeMaterialToOriginal()
		{
		}

		private void ChangeMaterial(string materialPath, bool weaponAlso = true)
		{
		}

		private void FindRenderers()
		{
		}
	}
}
