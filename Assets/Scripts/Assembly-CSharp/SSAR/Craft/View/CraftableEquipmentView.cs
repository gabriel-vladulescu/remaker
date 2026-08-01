using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftableEquipmentView : MonoBehaviour
	{
		public UILabel lb_title;

		public UILabel lb_rarityTitle;

		public UILabel lb_mainStatValue;

		public UILabel lb_mainStatTitle;

		public UITable table_substat;

		public UIWidget subStatWidget;

		public GameObject baseInfoContainer;

		private EquipmentSlotView equipmentSlotView;

		private EquipmentCollectData collectData;

		private UISprite sp_random;

		private CraftableEquipmentDetailView[] detailViews;

		internal void Init()
		{
		}

		private void InitEquipmentBaseInfoContainer()
		{
		}

		private void InitRandomSprite()
		{
		}

		private void InitDetailViews()
		{
		}

		private void ShowIcon()
		{
		}

		private void ShowMainInfo()
		{
		}

		private void ShowMainStat(EquipmentConfigId configId)
		{
		}

		private float[] GetMainStatRange(EquipmentConfigId configId)
		{
			return null;
		}

		private EquipmentTier[] GetTiers()
		{
			return null;
		}

		private void ShowSubInfo()
		{
		}

		private void ShowTier(int index)
		{
		}

		private void ShowSubStats(int index, EquipmentConfigId configId)
		{
		}

		private void ShowSockets(int index, EquipmentConfigId configId)
		{
		}

		private void ShowSkills(int index)
		{
		}

		internal void Show(EquipmentCollectData collectData)
		{
		}

		internal void Hide()
		{
		}
	}
}
