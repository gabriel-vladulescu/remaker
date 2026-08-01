using System.Collections.Generic;
using SSAR.BattleSystem.Collision;
using SSAR.Dungeon.HUD;
using UnityEngine;

namespace SSAR.Dungeon.Caching
{
	public class CharacterObjectCaching : MonoBehaviour
	{
		private class RimInfo
		{
			public Color color;

			public float scale;

			public RimInfo(Color color, float scale)
			{
			}
		}

		public Transform headPivot;

		private Vector3 originalScale;

		private ColliderConfigData colliderConfigData;

		private float flashTime;

		private FlashInfo flash;

		public const string COLOR_KEY = "_flashColor";

		public const string VALUE_KEY = "_flashValue";

		public const string RIM_COLOR_KEY = "_rimlightcolor";

		public const string RIM_VALUE_KEY = "_rimlightscale";

		public bool avaiableImmuneFlash;

		private IRenderMaterialControl renderMaterialControl;

		private bool isInFlash;

		private Renderer[] renderer;

		private Dictionary<Material, RimInfo> cacheRimInfos;

		public void Init()
		{
		}

		public void ChangeColliderConfigData(ColliderConfigData ccd)
		{
		}

		public Material[] GetMaterials(bool updateWeapon = false)
		{
			return null;
		}

		public Renderer GetRenderer()
		{
			return null;
		}

		public void SetMaterials(Material[] materials, bool reApplyShader = false, bool updateWeapon = false)
		{
		}

		public void UpdateMaterials(bool updateWeapon = false)
		{
		}

		public Vector3 GetHeadPivotPosition()
		{
			return default(Vector3);
		}

		public Vector3 GetFootPivotPosition()
		{
			return default(Vector3);
		}

		public Vector3 GetBodyPosition()
		{
			return default(Vector3);
		}

		private ColliderConfigData GetColliderConfigData()
		{
			return null;
		}

		public void SetHitFlash(FlashType flashType, string colorKey, string valueKey)
		{
		}

		public float SetImmuneFlash()
		{
			return 0f;
		}

		public void ForceFinishFlash()
		{
		}

		public void ResetFlash()
		{
		}

		private FlashInfo GetFlashInfo()
		{
			return null;
		}

		private void Update()
		{
		}

		private void SetAlphaValue(float value, bool applyColor)
		{
		}

		private void SetHitColor(Material material, string key)
		{
		}

		private void SetFlashAlpha(Material material, string key, float value)
		{
		}

		private void CacheRimInfo()
		{
		}

		private void ResetRimInfo()
		{
		}
	}
}
