using Assets.Scripts.Ssar.Pet.View;
using Scripts.Config;
using Scripts.Ssar.Pet;
using UnityEngine;

namespace Ssar.Event.SevenDaysCampaign.View
{
	public class CampaignMasterQuestRewardView : MonoBehaviour
	{
		public float unitGap;

		public UILabel lbName;

		public UILabel[] lbSkillNames;

		public PetSkillView[] skillViews;

		public GameObject btnChoose;

		public GameObject modelRoot;

		private GameObject petModel;

		private PetGenerationConfig petGenerationConfig;

		private PetVisualConfig petVisualConfig;

		private RandomPetConfig randomPetConfig;

		private PetConfig petConfig;

		private CampaignConfig.CampaignQuestItem questItem;

		private int index;

		private float centerIndex;

		private void Awake()
		{
		}

		private void Choose(GameObject go)
		{
		}

		private void Confirm()
		{
		}

		public void Init(PetGenerationConfig petGenerationConfig, PetVisualConfig petVisualConfig, RandomPetConfig randomPetConfig, GameObject modelRoot)
		{
		}

		internal void Show(CampaignConfig.CampaignQuestItem questItem, int index, float centerIndex)
		{
		}

		internal void Hide()
		{
		}

		private void LoadModel(PetConfigId petConfigId)
		{
		}

		private void OnLoadPetSuccess(GameObject obj)
		{
		}

		private void LoadSkills(PetConfigId petConfigId)
		{
		}
	}
}
