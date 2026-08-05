using System;
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

		// No real save/progression system exists (star/lock state per
		// node), so every node shown is treated as unlocked/enterable -
		// same "known-good default" convention used throughout this
		// project rather than fabricating fake progress data. Real
		// node reward/lost-soul/death-location decorations (progression
		// polish, not needed for "pick a dungeon and play") stay unused.
		public event Action<Scripts.Config.Dungeon> onClick;

		private void Awake()
		{
			if (objectClick != null)
			{
				UIEventListener.Get(objectClick).onClick += ClickObject;
			}
			if (stars != null)
			{
				foreach (UISprite star in stars)
				{
					if (star != null)
					{
						NGUITools.SetActive(star.gameObject, false);
					}
				}
			}
		}

		private void ClickObject(GameObject o)
		{
			if (dungeonInfo != null)
			{
				onClick?.Invoke(dungeonInfo);
			}
		}

		public void Show(Scripts.Config.Dungeon config)
		{
			dungeonInfo = config;
			gameObject.SetActive(config != null);
			if (config == null)
			{
				return;
			}
			UpdateName();
			UpdateBg();
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
			if (lb_name != null && dungeonInfo != null)
			{
				lb_name.text = "Node " + dungeonInfo.nodeOrder;
			}
		}

		private void UpdateBg()
		{
			if (sp_bg != null)
			{
				sp_bg.color = Color.white;
			}
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
