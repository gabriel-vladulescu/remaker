using Scripts.Ssar.Arena;
using UnityEngine;

namespace Ssar.LevelDesignTest.View
{
	public class TestLevelDesignScene : MonoBehaviour
	{
		public PvpTestCharacterContainer mainCharacter;

		public UILabel lb_difficulty;

		public UIPopupList PopupList;

		public UIInput spawnerInput;

		public UIInput terrainInput;

		public UIInput terrainColliderInput;

		public UIInput stageCameraInput;

		public UIInput stageIdsInput;

		[Header("Buttons")]
		public GameObject btn_start;

		public GameObject btn_back;

		public GameObject btn_loadSpawner;

		public GameObject btn_loadTerrain;

		public GameObject btn_loadTerrainCollider;

		public GameObject btn_loadStageCamera;

		private MainCharacterData mainCharacterData;

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

		private void GenerateSave()
		{
		}

		private void LoadSpawner(GameObject go)
		{
		}

		private void LoadTerrain(GameObject o)
		{
		}

		private void LoadTerrainCollider(GameObject o)
		{
		}

		private void LoadStageCamera(GameObject o)
		{
		}
	}
}
