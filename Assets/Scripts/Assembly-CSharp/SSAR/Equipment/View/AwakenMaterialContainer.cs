using System.Collections.Generic;
using Assets.Scripts.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class AwakenMaterialContainer : strange.extensions.mediation.impl.View
	{
		public GameObject mainItemContainer;

		public UILabel lb_lv;

		public UILabel lb_percent;

		public UILabel lb_materialCount;

		public UILabel lb_price;

		public UILabel lbDesc;

		public UITable table_price;

		public UIProgressBar ProgressBar;

		public UIProgressBar ExtraProgressBar;

		public GameObject btn_awaken;

		private EquipmentView equipmentView;

		private UIGrid grid;

		private List<AwakenMaterialView> materialViews;

		private IItem equipmentCollectData;

		protected override void Awake()
		{
		}

		private void Awaken(GameObject go)
		{
		}

		public void Show(IItem equipmentCollectData)
		{
		}

		public EquipmentView GetMainEquipmentView()
		{
			return null;
		}

		public void AddMaterial(IItem equipmentCollectData)
		{
		}

		public void RemoveMaterial(IItem equipmentCollectData)
		{
		}

		public void UpdateData()
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
	}
}
