using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using SSAR.View;
using Scripts.Ssar.Pet;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetInfoContainer : AbsItemInfoContainer
	{
		public UITable tableEquipment;

		public GameObject wg_baseInfo;

		public PetShareStatView[] PetShareStatViews;

		public PetSkillView[] PetSkillViews;

		public PetStatDetailContainer petStatDetailContainer;

		private EquipmentView equipmentView;

		private EquipmentSlotView[] slotViews;

		private bool isPreview;

		private MainCharacterData mainCharacterData;

		private IItem pet;

		protected override void OnInit()
		{
		}

		public void SetActiveWgInUse(bool active)
		{
		}

		protected override void OnShow(IItem item, ShowSubStatParameter[] main, ShowSubStatParameter[] showSubStatParameters, MainCharacterData mainCharacterData, bool isPreview)
		{
		}

		protected override EffectPathIndex UpgradeEffectPathIndex()
		{
			return default(EffectPathIndex);
		}

		private void ShowTransformStat(PetCollectData petCollectData, MainCharacterData mainCharacterData)
		{
		}

		private void ShowSkills(PetCollectData petCollectData)
		{
		}

		private void ShowEquipment(PetCollectData petCollectData, MainCharacterData mainCharacterData)
		{
		}

		private new void Init()
		{
		}

		private void InitSlot()
		{
		}

		private EquipmentType[] EquipmentTypes()
		{
			return null;
		}

		private void OnClickSlot(EquipmentCollectData equipmentCollectData, EquipmentType equipmentType)
		{
		}
	}
}
