using System;
using SSAR.Equipment.View;
using Scripts.Ssar.Pet;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Pet.View
{
	public class PetSlotView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_tier;

		public UILabel lb_rarity;

		public UILabel lb_enhance;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		public GameObject wg_tier;

		public GameObject icon_lock;

		public UISprite sp_changeVisualEnableRight;

		private PetCollectData petCollectData;

		private bool enableRarityTitle;

		private bool isLock;

		private Action<PetCollectData> onClick;

		private AwakenLevelView awakenLevelView;

		private MainCharacterData mainCharacterData;

		private Action onClickEnableVisual;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public void Init()
		{
		}

		public void Equip(PetCollectData petCollectData, MainCharacterData mainCharacterData)
		{
		}

		public void UnEquip()
		{
		}

		public void DisableRarityTitle()
		{
		}

		public void ListenOnClick(Action<PetCollectData> action)
		{
		}

		public void Disable()
		{
		}

		private void ActiveText(bool active)
		{
		}

		public void ListenOnClickEnableVisual(Action action)
		{
		}

		public void EnableVisual()
		{
		}

		public void DisableVisual()
		{
		}

		private void UpdateBtnEnableVisual()
		{
		}

		public void DisableChangeVisual()
		{
		}

		public void EnableChangeVisual()
		{
		}

		protected virtual void OnClickObject(GameObject o)
		{
		}
	}
}
