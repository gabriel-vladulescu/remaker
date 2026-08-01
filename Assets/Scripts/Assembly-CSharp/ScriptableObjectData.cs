using Assets.Scripts.Ssar.SceneLoader.View;
using SSAR.Dungeon.HUD;
using SSAR.SkillSystem.Model;
using Ssar.DailyChallenge.Test;
using Ssar.Database;
using Ssar.LevelDesignTest.Model;
using UnityEngine;
using buildTools;

public class ScriptableObjectData : MonoBehaviour
{
	private static readonly string FOLDER;

	public static readonly string AI_TOOL_PATH;

	public static readonly string GAME_CONFIG_PATH;

	public static readonly string HACK_TOOL_EFFECTOR_PATH;

	public static readonly string HUD_CONFIG_PATH;

	public static readonly string GAME_AILOG_PATH;

	public static readonly string SHAKE_CAMERA_PATH;

	public static readonly string TEST_DUNGEON_TOOL_PATH;

	public static readonly string SOUND_CONFIG_PATH;

	public static readonly string DEV_TOOLS_PATH;

	public static readonly string TUTORIAL_TOOLS_PATH;

	public static readonly string BUILD_TOOLS_PATH;

	public static readonly string LOADING_SCENE_PATH;

	public static readonly string TEST_RAID_TOOL_PATH;

	public static readonly string TEST_LEVEL_DESIGN_TOOL_PATH;

	public static readonly string FIREBASE_USER_DATA_CONFIG_PATH;

	public static readonly string CONTROLLER_LAYOUT_CONFIG_PATH;

	public static readonly string TEST_DAILY_CHALLENGE_PATH;

	public static AIEditorTools AiEditorTools;

	public static GameConfigPathScriptableObject GameConfigPathScriptableObject;

	public static HackToolsForEffector HackToolsForEffector;

	public static HUDConfig HUDConfig;

	public static GameAILogTools GameAiLogTools;

	public static ShakeCameraConfig ShakeCameraConfig;

	public static TestDungeonTools TestDungeonTools;

	public static SoundConfig SoundConfig;

	public static DevTools DevTools;

	public static TutorialConfig tutorialConfig;

	public static BuildConfigTool BuildConfigTool;

	public static LoadingSceneCharacterConfigScriptableObject LoadingSceneCharacterConfig;

	public static TestRaidTool TestRaidTool;

	public static TestLevelDesignTool TestLevelDesignTool;

	public static FirebaseUserDataConfig FirebaseUserDataConfig;

	public static ControllerLayoutConfig ControllerLayoutConfig;

	public static TestDailyChallengeData TestDailyChallengeData;

	private void Awake()
	{
	}

	public static void Init()
	{
	}

	private static T Load<T>(string path) where T : ScriptableObject
	{
		return null;
	}
}
