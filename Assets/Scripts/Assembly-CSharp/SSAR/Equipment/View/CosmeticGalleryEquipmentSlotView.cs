using System;
using SSAR.Equipment.Enum;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class CosmeticGalleryEquipmentSlotView : MonoBehaviour
	{
		public UISprite sp_quality;

		public UISprite sp_icon;

		public UISprite sp_changeVisualEnableLeft;

		public UISprite sp_changeVisualEnableRight;

		public EquipmentType type;

		private UISprite currentBtnChangeVisual;

		private Action<EquipmentType> onClickEnableVisual;

		private void Awake()
		{
		}

		public void Show(EquipmentVisualAvailableInfo visualAvailableInfo)
		{
		}

		public void ListenOnClickEnableVisual(Action<EquipmentType> action)
		{
		}

		public void Init(EquipmentType type, bool isLeft)
		{
		}

		public void UnEquip()
		{
		}

		public void DisableChangeVisual()
		{
		}

		public void EnableChangeVisual()
		{
		}

		public void UpdateBtnEnableVisual()
		{
		}

		public void EnableVisual()
		{
		}

		public void DisableVisual()
		{
		}

		public void Disable()
		{
		}
	}
}
