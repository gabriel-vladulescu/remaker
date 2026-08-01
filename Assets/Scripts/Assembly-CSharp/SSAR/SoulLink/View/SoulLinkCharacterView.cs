using Assets.Scripts.Ssar.CharacterSelection.Model;
using Scripts.Config;
using UnityEngine;

namespace Ssar.SoulLink.View
{
	public class SoulLinkCharacterView : MonoBehaviour
	{
		public UISprite sp_avatar;

		public UILabel lb_Name;

		public UILabel lb_Desc;

		public UILabel lb_NextLv;

		public UILabel lb_progress;

		public UILabel lb_NameDeactive;

		public UILabel lb_DescDeactive;

		public UILabel lb_NextLvDeactive;

		public UIProgressBar progressBar;

		public GameObject objActive;

		public GameObject objDeactive;

		public GameObject btnUnlock;

		private CharacterCode characterCode;

		private void Awake()
		{
		}

		private void Unlock(GameObject go)
		{
		}

		internal void Show(MainCharacterData mainCharacterData)
		{
		}

		internal void Lock(int characterId)
		{
		}

		private void UpdateIcon(CharacterCode charCode)
		{
		}

		private string GetWeapon(CharacterCode charCode, bool active)
		{
			return null;
		}

		private string GetName(MainCharacterData mainCharacterData)
		{
			return null;
		}

		private string GetBonusDesc(MainCharacterData mainCharacterData)
		{
			return null;
		}

		private string GetNextBonusDesc(SoulLinkConfig.Milestone milestone, SoulLinkConfig.Milestone nextMilestone)
		{
			return null;
		}

		private void DisplayProgress(int currentPower, SoulLinkConfig.Milestone milestone, SoulLinkConfig.Milestone nextMilestone)
		{
		}

		private SoulLinkConfig.Milestone GetNextMilestone(MainCharacterData mainCharacterData)
		{
			return null;
		}
	}
}
