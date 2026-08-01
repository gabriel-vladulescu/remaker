using Scripts.Ssar.Pet;
using UnityEngine;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetShareStatView : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_percent;

		private PetShareStat petShareStat;

		private PetCollectData petCollectData;

		private MainCharacterData mainCharacterData;

		private void Awake()
		{
		}

		public void Show(PetShareStat petShareStat, PetCollectData petCollectData, MainCharacterData mainCharacterData)
		{
		}

		public void Hide()
		{
		}

		private void ShowInfo(GameObject o)
		{
		}
	}
}
