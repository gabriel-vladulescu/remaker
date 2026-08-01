using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.SkillSystem.Utils;
using SSAR.SkillSystem.View;
using SSAR.View;
using UnityEngine;

public class SkillManagerPopup : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CEnableBoxColliderButton_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillManagerPopup _003C_003E4__this;

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
		public _003CEnableBoxColliderButton_003Ed__22(int _003C_003E1__state)
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

	public SkillManagerTabView[] TabViews;

	public ActiveSkillContainer ActiveSkillContainer;

	public SignatureSkillContainer SignatureSkillContainer;

	public PassiveSkillContainer PassiveSkillContainer;

	public GameObject btn_swapSkill;

	public GameObject resourcesContainer;

	public SkillManagerPresetTabView[] PresetTabViews;

	public ActiveSkillPointContainer ActiveSkillPointContainer;

	public GameObject btn_reset;

	public GameObject btn_purchase;

	private MainCharacterData cloneMainCharacterData;

	private MainCharacterData targetMainCharacterData;

	private bool allowEdit;

	private SkillTabType curTab;

	private UserResourcesView userResourcesView;

	private float timeEnable;

	private Preset preset;

	protected override void Awake()
	{
	}

	protected override void onEnable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void OnDisable()
	{
	}

	public void Show(MainCharacterData targetMainCharacterData, bool allowEdit, Preset preset)
	{
	}

	[IteratorStateMachine(typeof(_003CEnableBoxColliderButton_003Ed__22))]
	private IEnumerator EnableBoxColliderButton()
	{
		return null;
	}

	private void EnableBoxColliderButton(bool enable)
	{
	}

	private void Update()
	{
	}

	public void OnPurchaseSkilPointSuccess(int skillPointInc)
	{
	}

	public void OnAddCharacterSkillPointSuccess(int value)
	{
	}

	private void RefeshData()
	{
	}

	public void OnSwapSkill()
	{
	}

	public void InvestSkillPointToActiveSkill(int skillId, RuneType runeType, int value, Preset preset)
	{
	}

	public void DivestSkillPointFromActiveSkill(int skillId, RuneType runeType, Preset preset)
	{
	}

	public void InvestSkillPointToSignatureSkill(int skillId, int value, Preset preset)
	{
	}

	public void DivestSkillPointFromSignatureSkill(int skillId, Preset preset)
	{
	}

	public void InvestSkillPointToPassiveSkill(int skillId, int value, Preset preset)
	{
	}

	public void DivestSkillPointFromPassiveSkill(int skillId, Preset preset)
	{
	}

	private void InitTab()
	{
	}

	private void ClickTab(SkillTabType tabType)
	{
	}

	private void ClickTab(Preset preset)
	{
	}

	private void ShowTab(Preset preset)
	{
	}

	private void InitResources()
	{
	}

	private void SaveSkill(GameObject o)
	{
	}

	private void ResetSkill(GameObject o)
	{
	}

	public void SwapSkill(GameObject o)
	{
	}

	private void TestSkill(GameObject o)
	{
	}

	private void ValidateData(MainCharacterData data, Preset preset)
	{
	}

	public MainCharacterData GetCurrentCharacterData()
	{
		return null;
	}

	public void ForceEnableSwap()
	{
	}

	private void PurchaseSkill(GameObject o)
	{
	}
}
