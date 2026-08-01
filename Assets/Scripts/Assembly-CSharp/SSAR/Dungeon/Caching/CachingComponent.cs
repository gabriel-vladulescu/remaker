using Artemis.Interface;
using UnityEngine;

namespace SSAR.Dungeon.Caching
{
	public class CachingComponent : IComponent
	{
		private CharacterObjectCaching cache;

		private bool hasFlashHit;

		public CachingComponent(CharacterObjectCaching cache)
		{
		}

		public void UpdateCharacterObjectCaching(GameObject gameObject)
		{
		}

		public Material[] GetMaterials(bool updateWeapon = false)
		{
			return null;
		}

		public void SetMeterials(Material[] materials, bool reApplyShader = false, bool updateWeapon = false)
		{
		}

		public Vector3 GetBodyPosition()
		{
			return default(Vector3);
		}

		public Transform GetHeadPivot()
		{
			return null;
		}

		public void SetHitFlash(FlashType flashType)
		{
		}

		public void ForceFinishFlash()
		{
		}

		public void DisableFlashHit()
		{
		}

		public void EnableFlashHit()
		{
		}

		public void DisableImmuneFlash()
		{
		}

		public Vector3 GetFootPivotPosition()
		{
			return default(Vector3);
		}

		public Renderer GetRenderer()
		{
			return null;
		}

		public Vector3 GetSpinePosition()
		{
			return default(Vector3);
		}
	}
}
