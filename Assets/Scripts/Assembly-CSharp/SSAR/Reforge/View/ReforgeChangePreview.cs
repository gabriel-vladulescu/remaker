using Assets.Scripts.Ssar.Equipment;
using SSAR.Equipment.Model;
using Ssar.Reforge.Enum;
using UnityEngine;

namespace Ssar.Reforge.View
{
	public class ReforgeChangePreview : MonoBehaviour
	{
		public GameObject arrow;

		public UILabel lelfLabel;

		public UILabel rightLabel;

		public UITable leftContainer;

		public UITable rightContainer;

		[SerializeField]
		private GameObject rowPrefab;

		[SerializeField]
		private int maxRow;

		private ReforgeStatRowView[] leftStatRowViews;

		private ReforgeStatRowView[] rightStatRowViews;

		private EquipmentDropConfig equipmentDropConfig;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		public void Show(EquipmentCollectData equipment, ReforgeType reforgeType)
		{
		}

		public void Hide()
		{
		}

		private void DisplayTitle(ReforgeType reforgeType)
		{
		}

		private void DisplayCurrent(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment, ReforgeType reforgeType)
		{
		}

		private void DisplayPredition(ReforgeStatRowView[] statRowViews, EquipmentCollectData equipment, ReforgeType reforgeType)
		{
		}
	}
}
