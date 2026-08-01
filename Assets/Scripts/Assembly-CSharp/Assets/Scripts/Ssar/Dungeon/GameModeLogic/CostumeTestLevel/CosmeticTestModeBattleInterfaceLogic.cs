using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.Model;
using Assets.Scripts.Ssar.Dungeon.View;
using SSAR.Shop.Enum;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.CostumeTestLevel
{
	public class CosmeticTestModeBattleInterfaceLogic : IBattleInterfaceLogic, IDungeonInterfaceLogic
	{
		[CompilerGenerated]
		private sealed class _003CShowShopPopupCoro_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CosmeticTestModeBattleInterfaceLogic _003C_003E4__this;

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
			public _003CShowShopPopupCoro_003Ed__16(int _003C_003E1__state)
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

		private AdventureWinButtonContainer buttonContainer;

		private bool isGalleryScene;

		[Inject]
		public ShopTabType tab { get; set; }

		public CosmeticTestModeBattleInterfaceLogic(bool isGalleryScene)
		{
		}

		public string GetDungeonName()
		{
			return null;
		}

		public string GetStageDesc()
		{
			return null;
		}

		public void Instantiate()
		{
		}

		public void InstantiateButtonInWinPopup(GameObject parent)
		{
		}

		public void SetActiveButtonInWinPopup(bool active)
		{
		}

		public bool IsEnableWatchAdsToDoubleReward()
		{
			return false;
		}

		public void DungeonPausePopupExit()
		{
		}

		public void DungeonLosePopupClickExit()
		{
		}

		private void Back(bool isGalleryScene)
		{
		}

		[IteratorStateMachine(typeof(_003CShowShopPopupCoro_003Ed__16))]
		private IEnumerator ShowShopPopupCoro()
		{
			return null;
		}

		public bool EnableStartWarning()
		{
			return false;
		}

		public string StartWarningMainText()
		{
			return null;
		}

		public string StartWarningSubText()
		{
			return null;
		}

		public bool WarningWhenClickExitInPopupPause()
		{
			return false;
		}
	}
}
