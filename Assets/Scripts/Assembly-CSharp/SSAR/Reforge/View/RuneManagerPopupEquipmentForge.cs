using System;
using Assets.Scripts.Ssar.Rune.View;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Ssar.Rune.Model;
using UnityEngine;

namespace Ssar.Reforge.View
{
	public class RuneManagerPopupEquipmentForge : MonoBehaviour
	{
		public GameObject btnClose;

		public GameObject btnReforgeFree;

		public GameObject btnReforgePrice;

		public GameObject widgetItem;

		public GameObject widgetRune;

		public UILabel lbReforeTime;

		public UILabel lbReforePrice;

		public UITable tablePrice;

		public ReforgeChangePreview changePreview;

		private EquipmentCardInfo equipmentCard;

		private RuneSimpleInfoView runeCard;

		private EquipmentCollectData equipmentCollectData;

		private Ssar.Rune.Model.Rune runeData;

		private Action onClose;

		private void Awake()
		{
		}

		public void ListenerOnClose(Action action)
		{
		}

		public void Hide()
		{
		}

		public void Show(EquipmentCollectData equipmentCollectData)
		{
		}

		public void Refresh(EquipmentCollectData equipmentCollectData)
		{
		}

		public void SetRune(Ssar.Rune.Model.Rune rune)
		{
		}

		private void Init()
		{
		}

		private void ShowRune()
		{
		}

		private void ShowPrice()
		{
		}

		private void ShowForgePrediction()
		{
		}

		private void ShowReforgeTimes()
		{
		}

		private void OnClickReforgeBtn()
		{
		}

		private void SendReforgeSignal()
		{
		}

		private bool ValidateRune(Ssar.Rune.Model.Rune rune, bool showTooltip)
		{
			return false;
		}

		private bool IsInvalidWeaponOnlyRune(Ssar.Rune.Model.Rune rune)
		{
			return false;
		}

		private bool IsMaxAllSkill(Ssar.Rune.Model.Rune rune)
		{
			return false;
		}

		private bool IsMaxReforgeCount()
		{
			return false;
		}
	}
}
