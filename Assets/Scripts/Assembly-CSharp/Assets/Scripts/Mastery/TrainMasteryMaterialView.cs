using Ssar.Rune.Model;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class TrainMasteryMaterialView : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_quantity;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		private RuneRarity runeRarity;

		private RuneType runeType;

		private void Awake()
		{
		}

		public void Show(RuneRarity runeRarity, int count)
		{
		}

		public void Hide()
		{
		}

		private void Remove(GameObject o)
		{
		}
	}
}
