using Assets.Scripts.Ssar.Worldmap.View;
using SSAR.WorldMap.Enum;
using SSAR.WorldMap.Model;
using Scripts.Config;
using Ssar.WorldMap.View;
using UnityEngine;

namespace SSAR.View
{
	public class WorldmapNodeView : MonoBehaviour
	{
		public UILabel lb_name;

		public UISprite sp_bg;

		public UISprite sp_icon;

		public UISprite[] stars;

		public GameObject objectClick;

		private Scripts.Config.Dungeon dungeonInfo;

		private NodeBonusRewardView nodeBonusRewardView;

		private GameObject fx;

		private NodeLostSoulView nodeLostSoulView;

		private NodeDeathLocationView nodeDeathLocationView;

		private bool isForceDeathLocation;

		private WorldMapData WorldMapData => null;

		private void Awake()
		{
		}

		private void ClickObject(GameObject o)
		{
		}

		public void Show(Scripts.Config.Dungeon config)
		{
		}

		private void UpdateNodeBonusReward()
		{
		}

		private void UpdateLostSoul()
		{
		}

		private void UpdateDeathLocationView()
		{
		}

		private void UpdateFxInsane()
		{
		}

		private void UpdateStar()
		{
		}

		private void UpdateName()
		{
		}

		private void UpdateBg()
		{
		}

		private string GetIcon()
		{
			return null;
		}

		private bool IsDeathLocation()
		{
			return false;
		}

		private bool IsDungeonBoss()
		{
			return false;
		}

		private NodeProgress GetNodeProgress()
		{
			return null;
		}

		private NodeStatus GetNodeStatus()
		{
			return default(NodeStatus);
		}

		private void InitFontSize()
		{
		}

		private void InitNodeBonusReward()
		{
		}

		private void InitFx()
		{
		}

		private void InitLostSouls()
		{
		}

		private void InitDeathLocation()
		{
		}

		internal void ForceDeathLocation(bool value)
		{
		}

		internal void ForceLostSouls(int value)
		{
		}
	}
}
