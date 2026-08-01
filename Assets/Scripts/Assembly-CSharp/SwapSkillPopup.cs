using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

public class SwapSkillPopup : BasePopup
{
	private class SkillSlotData
	{
		public int skillId;

		public int slot;

		public SkillSlotData(int skillId, int slot)
		{
		}
	}

	public UITable table_skill;

	public GameObject slot1;

	public GameObject slot2;

	public GameObject slot3;

	public GameObject slot4;

	public GameObject btn_confirm;

	public GameObject btn_cancel;

	public GameObject btn_exit;

	public GameObject notify;

	private List<SkillItemView> ListSkillCanEquipView;

	private List<SkillItemView> skillItemViewsEquipped;

	private List<SkillItemView> listSkillSelected;

	private MainCharacterData mainCharacterData;

	private MainCharacterData cloneMainCharacterData;

	private Preset preset;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(MainCharacterData mainCharacterData, Preset preset)
	{
	}

	public void UpdateActiveSkillSelected(List<int> listActiveSkill, Preset preset)
	{
	}

	private void InitSkill()
	{
	}

	private void UpdateData()
	{
	}

	private void UpdateRightPanelView(List<CharacterActiveSkillStat> listSkillCanEquip)
	{
	}

	private void InitCollider(SkillItemView skillItemView)
	{
	}

	private void ClickIconSkill(GameObject o)
	{
	}

	private bool CanSelectSlot(SkillItemView skillItemView)
	{
		return false;
	}

	private void ClearSelect()
	{
	}

	private void SelectSlot(SkillItemView skillItemView)
	{
	}

	private void SwapSlot()
	{
	}

	private void Swap(SkillSlotData a, SkillSlotData b)
	{
	}

	private void Confirm(GameObject o)
	{
	}

	private void Test(GameObject o)
	{
	}
}
