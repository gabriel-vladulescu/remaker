using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.Dungeon.Model;
using SSAR.Dungeon.View;
using UnityEngine;

public class DungeonWinPopup : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CDelay2_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CDelay2_003Ed__29(int _003C_003E1__state)
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

	public DungeonWinStarContainer StarContainer;

	public DungeonWinUserInfoContainer UserInfoContainer;

	public DungeonWinRewardContainer DungeonWinRewardContainer;

	public DungeonWinBonusRewardContainer DungeonWinBonusRewardContainer;

	public RatingPopUpView RatingPopUpView;

	public GameObject btn_lobby;

	public GameObject btn_skill;

	public GameObject btn_inventory;

	public GameObject btn_mastery;

	public GameObject rightBottomButtonContainer;

	private bool isClickBtnLobby;

	private DungeonWinParameter winParameter;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	private void Update()
	{
	}

	protected override void ExecuteBack()
	{
	}

	private void BackLobby()
	{
	}

	private void OpenSkill(GameObject o)
	{
	}

	private void OpenInventory(GameObject o)
	{
	}

	private void OpenMastery(GameObject o)
	{
	}

	public void Show(DungeonWinParameter parameter)
	{
	}

	public void AddBonusExpFromWatchVod(int exp)
	{
	}

	public void AddBonusSoulFromWatchVod(int soul)
	{
	}

	public void AddEquipmentFromWatchVod(EquipmentConfigId afterRandom)
	{
	}

	public void ClickBtnLobby()
	{
	}

	private void DisableAnotherView()
	{
	}

	private void SetActiveButton(bool active)
	{
	}

	public void HideAllButtonAndOnlyShowLobby()
	{
	}

	private void Lobby(GameObject o)
	{
	}

	[IteratorStateMachine(typeof(_003CDelay2_003Ed__29))]
	private IEnumerator Delay2()
	{
		return null;
	}

	private void CheckAndShowBonus()
	{
	}

	private IBattleModeLogic BattleModeLogic()
	{
		return null;
	}

	private void CheckUnlockMastery(bool active)
	{
	}
}
