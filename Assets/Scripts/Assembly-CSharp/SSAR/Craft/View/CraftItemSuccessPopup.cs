using System;
using Assets.Scripts.Ssar.Rune.View;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Ssar.Rune.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftItemSuccessPopup : BasePopup
	{
		public GameObject container;

		public GameObject btnOk;

		public GameObject mask;

		public UIPanel detailPane;

		public TweenScale light;

		public TweenScale info;

		private EquipmentInfoContainer equipmentInfoContainer;

		private RuneInfoView runeInfoView;

		private Action callback;

		protected override void Awake()
		{
		}

		private void Confirm(GameObject go)
		{
		}

		private void Confirm()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Init()
		{
		}

		private void InitRune()
		{
		}

		private void InitEquipment()
		{
		}

		private void ShowEquipment(EquipmentCollectData collectData)
		{
		}

		private void ShowRune(Ssar.Rune.Model.Rune rune)
		{
		}

		internal void Show(ICollectData collectData, Action callback)
		{
		}
	}
}
