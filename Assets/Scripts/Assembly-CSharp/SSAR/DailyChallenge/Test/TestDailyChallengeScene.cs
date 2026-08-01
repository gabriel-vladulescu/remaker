using Scripts.Ssar.Arena;
using UnityEngine;

namespace Ssar.DailyChallenge.Test
{
	public class TestDailyChallengeScene : MonoBehaviour
	{
		public PvpTestCharacterContainer mainCharacter;

		public UILabel lb_difficulty;

		public UIPopupList PopupList;

		public GameObject roundIdContainer;

		public UIInput seedInput;

		[Header("Buttons")]
		public GameObject btn_start;

		public GameObject btn_back;

		public GameObject btn_generate;

		public GameObject btn_random;

		private MainCharacterData mainCharacterData;

		private UIInput[] roundIdInputs;

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

		private void GenerateRound(GameObject go)
		{
		}

		private void RandomRound(GameObject go)
		{
		}

		private ScenarioDifficulty Difficulty()
		{
			return default(ScenarioDifficulty);
		}

		private void GenerateSave()
		{
		}

		private void UpdateRoundInputs(TestDailyChallengeData tool)
		{
		}

		private int[] GetRoundIds()
		{
			return null;
		}
	}
}
