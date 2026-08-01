using System;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class EventFrameConfig
	{
		public bool foldout;

		public int eventType;

		public int frame;

		public ActionFrameConfig actionFrameConfig;

		public const char delimiter = ';';

		[PreloadPool.PrefabPathMarker]
		public string vfxPrefabPath;

		public bool vfxFollowCasterPosition;

		public bool vfxIgnoreCasterPositionOnYAxis;

		public string vfxConfigString;

		[NonSerialized]
		public VfxConfig vfxConfig;

		public string sfxPath;

		public float sfxVolume;

		public float sfxSpeed;

		public string spawnMonsterConfigString;

		[NonSerialized]
		public SpawnMonsterConfig spawnMonsterConfig;

		public float moveDistance;

		public int moveEndFrame;

		public float moveBlendTime;

		public bool moveAdjustCollider;

		public Vector2 moveColliderCenter;

		public Vector2 moveColliderSize;

		public string moveExtras;

		public bool moveBackward;

		public bool moveTowardTarget;

		public bool ignoreMoveDirection;

		public string moveConfigString;

		[NonSerialized]
		public MoveConfig moveConfig;

		public int jumpCount;

		public float jumpHeight;

		public float jumpDurationReachMaxHeight;

		public float jumpDurationLandGround;

		public float jumpDistance;

		public bool jumpDisableOnGround;

		public float floatingDuration;

		public bool jumpBackward;

		public float moveTowardDirectionSpeed;

		public float moveTowardDirectionDuration;

		public float moveTowardDirectionSpeed2;

		public float moveTowardDirectionDuration2;

		public float moveTowardDirectionSpeed3;

		public float moveTowardDirectionDuration3;

		public float moveTowardDirectionDistance;

		public float moveTowardDirectionDistance2;

		public float moveTowardDirectionDistance3;

		public bool moveTowardDirectionReachTargetPosition;

		public bool moveTowardDirectionReachBySpeed;

		public bool moveTowardDirectionReachTargetPositionIgnoreY;

		public string moveTowardDirectionPlayAnimationName;

		public string moveTowardDirectionSkipAnimationName;

		public int appearAtFrame;

		public int teleportMode;

		public int teleportNotificationFrame;

		[PreloadPool.PrefabPathMarker]
		public string teleportNotificationPrefabPath;

		public Vector2 teleportDestinationRelativePosition;

		public int teleportFrameToTrackTargetPosition;

		public float teleportDestinationPadding;

		public bool isIgnoreTargetY;

		public string teleportString;

		[NonSerialized]
		public TeleportConfig teleportConfig;

		public int disableColliderEndFrame;

		public string cameraFxConfigString;

		[NonSerialized]
		public CameraFxConfig cameraFxConfig;

		public string buffString;

		[NonSerialized]
		public BuffConfig buffObject;

		public string cornerJumpString;

		[NonSerialized]
		public CornerJumpConfig cornerJumpObject;

		public string moveUsingSpeedString;

		[NonSerialized]
		public MoveUsingSpeedConfig moveUsingSpeedObject;

		public string flyUpwardString;

		[NonSerialized]
		public FlyUpwardConfig flyUpwardConfig;

		public string dragString;

		[NonSerialized]
		public DragConfig dragConfig;

		public string vfxFollowBoneString;

		[NonSerialized]
		public VfxFollowBoneConfig vfxFollowBoneConfig;

		public string sfxRandomlyString;

		[NonSerialized]
		public SfxRandomlyConfig sfsRandomlyConfig;

		public string forceStopMoveConfigString;

		[NonSerialized]
		public ForceStopMoveConfig forceStopMoveConfig;

		public string playAnimConfigString;

		[NonSerialized]
		public PlayAnimationConfig playAnimationConfig;

		public string suicideConfigString;

		[NonSerialized]
		public SuicideConfig suicideConfig;

		public string materialPath;

		public string objectName;

		public float materialEndFrame;

		public int Frame(float scaleTime)
		{
			return 0;
		}

		public string RandomVfxPrefabPath()
		{
			return null;
		}

		public string[] VfxPrefabPaths()
		{
			return null;
		}

		public static string[] VfxPrefabPaths(string path)
		{
			return null;
		}

		public static string CreateVfxPrefabPathString(string[] paths)
		{
			return null;
		}

		public int MoveEndFrame(float scaleTime)
		{
			return 0;
		}

		public float MoveBlendTime(float scaleTime)
		{
			return 0f;
		}

		public VfxConfig GetVfxConfig()
		{
			return null;
		}

		public SpawnMonsterConfig SpawnMonsterConfig()
		{
			return null;
		}

		public BuffConfig BuffConfig()
		{
			return null;
		}

		public CornerJumpConfig CornerJumpConfig()
		{
			return null;
		}

		public MoveUsingSpeedConfig MoveUsingSpeedObject()
		{
			return null;
		}

		private string JsonSerialize(object obj)
		{
			return null;
		}

		private T JsonDeserialize<T>(string json)
		{
			return default(T);
		}

		public void OnAfterDeserialize(SkillEventFrameConfig config)
		{
		}

		public void ClearPrefabPaths()
		{
		}
	}
}
