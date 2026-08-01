using System;
using Assets.Scripts.Ssar.BloodyTower.Enum;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.BloodyTower.View
{
	public class BloodyTowerFloorView : MonoBehaviour
	{
		public UISprite sp_overlay;

		public UILabel lb_floor;

		public GameObject wgCommingSoon;

		public UISprite[] sp_star;

		public UITable table_name;

		public int floor;

		public UIWidget wgSelect;

		private GameObject fx;

		private FloorStatus floorStatus;

		private Action<int> onSelect;

		private void Awake()
		{
		}

		public void Init(int floor, Action<int> onSelect)
		{
		}

		public void Show(FloorStatus status, bool isSelected)
		{
		}

		private void GetFloorVisual(FloorStatus status, out string overlaySpriteName, out string floorNameFormat, out int star)
		{
			overlaySpriteName = null;
			floorNameFormat = null;
			star = default(int);
		}

		private ConfigManager GetConfigManager()
		{
			return null;
		}

		private bool CanShowReward(FloorStatus status)
		{
			return false;
		}

		private bool CanShowStart(FloorStatus status)
		{
			return false;
		}

		private void Init()
		{
		}
	}
}
