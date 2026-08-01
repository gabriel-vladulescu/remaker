using Scripts.Ssar.Arena;
using Ssar.RaidBoss.Model;
using UnityEngine;

namespace Ssar.RaidBoss.Test
{
	public class TestRaidScene2 : MonoBehaviour
	{
		private class CompanionData
		{
			public int index;

			public MainCharacterData CharacterData;
		}

		public PvpTestCharacterContainer mainCharacter;

		public PvpTestCharacterContainer[] companionCharacters;

		public UIInput lab;

		public UIInput node;

		public UILabel lb_difficulty;

		public UIPopupList PopupList;

		public UIToggle[] Toggles;

		public GameObject btn_start;

		public GameObject btn_startDungeon;

		public GameObject btn_back;

		private MainCharacterData mainCharacterData;

		private CompanionData[] companionCharacterData;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Enter(GameObject go)
		{
		}

		private void EnterDungeon(GameObject go)
		{
		}

		private RaidTeamData GetTeam()
		{
			return null;
		}

		private ScenarioDifficulty Difficulty()
		{
			return default(ScenarioDifficulty);
		}

		private void GenerateSave()
		{
		}

		public void EnableCompanion(GameObject go)
		{
		}
	}
}
