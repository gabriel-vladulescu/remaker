using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.DataManager;
using Checking;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.HellMode
{
	public class HellModeLogic
	{
		private class Tracker
		{
			private GameObject tombstone;

			private DeathLocation deathLocation;

			private GameObject hero;

			private MainCharacterData mainCharacterData;

			private ResourcesLoader resourcesLoader;

			private readonly HellModeLogic hml;

			private NotNullReference nnf;

			private bool collected;

			public bool Collected => false;

			public DeathLocation DeathLocation => null;

			public Tracker(GameObject tombstone, DeathLocation deathLocation, GameObject hero, MainCharacterData mainCharacterData, ResourcesLoader resourcesLoader, HellModeLogic hml)
			{
			}

			public void Update()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CUpdateTrackers_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HellModeLogic _003C_003E4__this;

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
			public _003CUpdateTrackers_003Ed__15(int _003C_003E1__state)
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

		private readonly ScenarioDifficulty[] affecteDifficulties;

		private DungeonConfig dungeonConfig;

		private MainCharacterData mainCharacterData;

		private ResourcesLoader resourcesLoader;

		private int capacity;

		private List<Tracker> trackers;

		private int counter;

		public HellModeLogic(DungeonConfig dungeonConfig, MainCharacterData mainCharacterData, ResourcesLoader resourcesLoader, int capacity)
		{
		}

		public bool IsHellModeEnableWithId(int dungeonId)
		{
			return false;
		}

		public void OnDungeonLose(int dungeonId)
		{
		}

		public void OnDungeonStart(int dungeonId)
		{
		}

		public int OnDungeonWin(int dungeonId)
		{
			return 0;
		}

		public void Update()
		{
		}

		public int GetDeathLocationsCount()
		{
			return 0;
		}

		public bool IsJustRemoveOldestLocation()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CUpdateTrackers_003Ed__15))]
		private IEnumerator UpdateTrackers()
		{
			return null;
		}

		private GameObject HeroGameObject()
		{
			return null;
		}
	}
}
