using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.BloodyTower.View;
using UnityEngine;

public class BloodyTowerPopup : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CDelayMoveFloor_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BloodyTowerPopup _003C_003E4__this;

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
		public _003CDelayMoveFloor_003Ed__20(int _003C_003E1__state)
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

	public UITable table;

	public UIScrollBar ScrollBar;

	public UIScrollBar bgScrollBar;

	public GameObject resourceContainer;

	public GameObject btn_equipment;

	public GameObject btn_skill;

	public GameObject btn_chest;

	public GameObject btn_mastery;

	public GameObject bottom;

	public GameObject wg_start;

	private BloodyTowerStartContainer bloodyTowerStartContainer;

	private List<BloodyTowerFloorView> bloodyTowerFloorViews;

	private ParticleRunAroundFx particleRunAroundFx;

	private int floorSelected;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void OnEnable()
	{
	}

	private void OpenMastery(GameObject go)
	{
	}

	private void Init()
	{
	}

	public void Show()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayMoveFloor_003Ed__20))]
	private IEnumerator DelayMoveFloor()
	{
		return null;
	}

	private void UpdateData()
	{
	}

	private void InitResources()
	{
	}

	private void InitFloor()
	{
	}

	private void SelectFloor(int floor)
	{
	}

	private int HighestFloorPlayable()
	{
		return 0;
	}

	private int CurrentFloor()
	{
		return 0;
	}

	private void OpenSkillManager(GameObject o)
	{
	}

	private void OpenChest(GameObject o)
	{
	}

	private void OpenEquipment(GameObject o)
	{
	}

	private void MoveFloorToCurrent()
	{
	}
}
