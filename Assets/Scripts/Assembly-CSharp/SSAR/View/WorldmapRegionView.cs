using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace SSAR.View
{
	public class WorldmapRegionView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayActiveEffect_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameObject o;

			public Transform parent;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelayActiveEffect_003Ed__13(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public UILabel lb_name;

		public UITexture bg;

		public WorldmapNodeView[] WorldmapNodeViews;

		[SerializeField]
		private GameObject hellModeReminder;

		private MapInfo mapInfo;

		private ScenarioDifficulty difficulty;

		private GameObject fx;

		private DungeonConfig cachedDungeonConfig;

		public event Action<Scripts.Config.Dungeon> onNodeClick;

		private DungeonConfig DungeonConfig
		{
			get
			{
				if (cachedDungeonConfig == null)
				{
					TextAsset json = UnityEngine.Resources.Load<TextAsset>("config/DungeonConfig");
					cachedDungeonConfig = new DungeonConfig();
					if (json != null)
					{
						cachedDungeonConfig.OnMapValue(json.text);
					}
				}
				return cachedDungeonConfig;
			}
		}

		private void Awake()
		{
			if (WorldmapNodeViews != null)
			{
				foreach (WorldmapNodeView node in WorldmapNodeViews)
				{
					if (node != null)
					{
						node.onClick += OnNodeClicked;
					}
				}
			}
			if (hellModeReminder != null)
			{
				NGUITools.SetActive(hellModeReminder, false);
			}
		}

		private void OnNodeClicked(Scripts.Config.Dungeon dungeon)
		{
			onNodeClick?.Invoke(dungeon);
		}

		public void Show(MapInfo mapInfo, ScenarioDifficulty difficulty)
		{
			this.mapInfo = mapInfo;
			this.difficulty = difficulty;
			if (lb_name != null && mapInfo != null)
			{
				lb_name.text = mapInfo.name;
			}
			UpdateNodeData();
		}

		private void UpdateNodeData()
		{
			if (WorldmapNodeViews == null || mapInfo == null)
			{
				return;
			}

			List<Scripts.Config.Dungeon> dungeons = DungeonConfig.GetListDungeons(mapInfo.id, difficulty);
			for (int i = 0; i < WorldmapNodeViews.Length; i++)
			{
				WorldmapNodeView node = WorldmapNodeViews[i];
				if (node == null)
				{
					continue;
				}
				node.Show(i < dungeons.Count ? dungeons[i] : null);
			}
		}

		private void UpdateEffectHighestNode()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayActiveEffect_003Ed__13))]
		private IEnumerator DelayActiveEffect(GameObject o, Transform parent)
		{
			return null;
		}

		private void InitFx()
		{
		}

		private void UpdateHellModeReminder()
		{
		}
	}
}
