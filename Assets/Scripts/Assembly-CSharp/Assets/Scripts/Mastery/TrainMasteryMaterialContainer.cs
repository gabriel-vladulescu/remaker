using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class TrainMasteryMaterialContainer : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_masteryname;

		public UILabel lb_lv;

		public UILabel lb_percent;

		public UILabel lb_materialCount;

		public UILabel lb_price;

		public UILabel lbDesc;

		public UITable table_price;

		public UIProgressBar ProgressBar;

		public UIProgressBar ExtraProgressBar;

		public GameObject btn_awaken;

		private List<TrainMasteryMaterialView> materialViews;

		private UIGrid grid;

		private void Awake()
		{
		}

		public void Show(MasteryInfo masteryInfo)
		{
		}

		private void Awaken(GameObject go)
		{
		}

		public void AddMaterial()
		{
		}

		public void RemoveMaterial()
		{
		}

		private void ShowMaterial()
		{
		}

		private void UpdateData()
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
