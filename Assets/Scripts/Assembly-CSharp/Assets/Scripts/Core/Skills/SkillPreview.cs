using Artemis;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Combat.Skills;
using Assets.Scripts.Ssar.Common.System.Resources;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class SkillPreview : MonoBehaviour
	{
		private static bool activated;

		private static int staticGroupId;

		private static int staticSubId;

		private static int staticLevel;

		public static GameObject go;

		public GameObject entity;

		public int groupId;

		public int subId;

		public int level;

		private TestUserInput userInput;

		private TestEvent event_;

		private HeroStateMachine entityStateMachine;

		private DefaultSkillCharacter character;

		private EntityWorld entityWorld;

		private ConfigManager configManager;

		private MonsterConfig monsterConfig;

		private HeroConfig heroConfig;

		private ResourcesSubSystem resourcesSubSystem;

		private SkillPreviewInput skillPreviewInput;

		private GameObject previousEntity;

		private bool ready;

		public static bool IsActivated()
		{
			return false;
		}

		public static int GroupId()
		{
			return 0;
		}

		public static int SubId()
		{
			return 0;
		}

		public static int Level()
		{
			return 0;
		}

		private void Start()
		{
		}

		private EquippedSkill CreateEquipSkill(string skillId, SkillEventFrameConfig sefc)
		{
			return null;
		}

		private void InitForMonster()
		{
		}

		private void OnPreloadComplete()
		{
		}

		private void Update()
		{
		}

		private void InitInput()
		{
		}
	}
}
