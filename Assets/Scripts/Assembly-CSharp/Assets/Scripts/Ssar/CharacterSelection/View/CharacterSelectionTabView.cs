using System;
using Assets.Scripts.Ssar.CharacterSelection.Model;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.CharacterSelection.View
{
	public class CharacterSelectionTabView : MonoBehaviour
	{
		private class ToggleValidator : IToggleValidator
		{
			private bool available;

			public ToggleValidator(CharacterCode tabType)
			{
			}

			public bool IsValid(GameObject o)
			{
				return false;
			}
		}

		public UIToggle toggle;

		public GameObject wg_active;

		public GameObject wg_default;

		public UISprite sp_weapon;

		public UISprite sp_weapon_active;

		public UISprite sp_avatar;

		public UISprite sp_status;

		public UILabel lb_status;

		public CharacterCode tabType;

		public Action<CharacterCode> onSelect;

		protected void Awake()
		{
		}

		public void Init(CharacterSelectionElementInfo info, Action<CharacterCode> onSelect)
		{
		}

		public void DisableStatus()
		{
		}

		public void UpdateTextDefault()
		{
		}

		public void UpdateText(string top, string bot)
		{
		}

		public void OnChangeTab(CharacterCode tabType)
		{
		}

		private void onChange()
		{
		}

		private void GetName(CharacterCode type, out string firstName, out string lastName)
		{
			firstName = null;
			lastName = null;
		}

		private void UpdateIcon(CharacterCode charCode)
		{
		}

		private string GetWeapon(CharacterCode charCode, bool active)
		{
			return null;
		}

		private string GetStatus(CharacterSelectionElementInfo info)
		{
			return null;
		}

		private string GetStatusText(CharacterSelectionElementInfo info)
		{
			return null;
		}
	}
}
