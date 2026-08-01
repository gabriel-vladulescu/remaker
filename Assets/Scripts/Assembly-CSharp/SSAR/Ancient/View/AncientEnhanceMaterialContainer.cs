using System.Collections.Generic;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.Ancient.View
{
	public class AncientEnhanceMaterialContainer : strange.extensions.mediation.impl.View
	{
		public GameObject mainItemContainer;

		public UILabel lb_lv;

		public UILabel lb_percent;

		public UILabel lb_materialCount;

		public UILabel lb_price;

		public UITable table_price;

		public UIProgressBar ProgressBar;

		public GameObject btn_enhance;

		private EquipmentCollectData mainAncient;

		private EquipmentView equipmentView;

		private UIGrid grid;

		private List<AncientEnhanceMaterialView> materialViews;

		protected override void Awake()
		{
		}

		private void Init()
		{
		}

		private void InitMaterial()
		{
		}

		private void Clear()
		{
		}

		private void Enhance(GameObject go)
		{
		}

		public void Show(EquipmentCollectData equipmentCollectData)
		{
		}

		public void AddMaterial(EquipmentCollectData equipmentCollectData)
		{
		}

		public void RemoveMaterial(EquipmentCollectData equipmentCollectData)
		{
		}

		private void UpdateData()
		{
		}
	}
}
