using System;
using System.Collections.Generic;
using Artemis;
using Artemis.Interface;
using Artemis.Utils;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using SSAR.BattleSystem.Collision;
using SSAR.BattleSystem.Movement;
using Scripts.Config.Stats;
using UnityEngine;

namespace SSAR.BattleSystem.Utils
{
	public static class BattleUtils
	{
		private class EffectRestriction
		{
			private static EffectPathIndex[] affected_effects;

			private static int max;

			private static float cooldown;

			private string[] paths;

			private Dictionary<string, float[]> spawnTimesByEffectPaths;

			public bool IsUsable(string effectPath)
			{
				return false;
			}

			public void Use(string effectPath)
			{
			}

			private float[] SpawnTimesOf(string effectPath)
			{
				return null;
			}

			private bool IsEffectNeedToBeRestricted(string effectPath)
			{
				return false;
			}
		}

		public static string ALLIANCE_GROUP;

		public static string MAIN_CHARACTER_TAG;

		public static string PROJECTILE;

		public static string ENEMY_GROUP;

		public static string BOSS_TAG;

		public static string MINIBOSS_TAG_1;

		public static string MINIBOSS_TAG_2;

		public static string MINIBOSS_TAG_3;

		public static string MINIBOSS_TAG_4;

		public static int count;

		public static float time;

		public static int frame;

		private static EffectRestriction effectRestriction;

		private static int randomSeed;

		static BattleUtils()
		{
		}

		public static int GetCurrentFrame()
		{
			return 0;
		}

		public static void InitRandomSeed(int randomSeed)
		{
		}

		public static Vector3 InsideUnitSphere()
		{
			return default(Vector3);
		}

		public static Vector2 InsideUnitCircle()
		{
			return default(Vector2);
		}

		public static Vector3 OnUnitSphere()
		{
			return default(Vector3);
		}

		public static float RandomRange(float min, float max)
		{
			return 0f;
		}

		public static int RandomRange(int min, int max)
		{
			return 0;
		}

		public static int RandomRangeInteger(int min, int max)
		{
			return 0;
		}

		public static float GetJumpVelocityVertical(float gravity, float durationReachMaxHeight)
		{
			return 0f;
		}

		public static bool RandomHit(float rate)
		{
			return false;
		}

		public static float GetJumpGravity(float maxHeight, float durationReachMaxHeight)
		{
			return 0f;
		}

		public static float GetVelocityHorizontal(float distance, float time)
		{
			return 0f;
		}

		public static float GetJumpTotalDistance(float jumpDistanceFromStartJumpUntilFall, float durationReachMaxHeight, float durationLandGround)
		{
			return 0f;
		}

		public static float CalculateJumpDistanceFromStartUntilFall(float totalDistance, float durationReachMaxHeight, float durationLandGround)
		{
			return 0f;
		}

		public static bool IsValidEntity<T>(Entity e) where T : IComponent
		{
			return false;
		}

		public static bool IsValidEntity(Entity e)
		{
			return false;
		}

		public static Vector3 ClampPositionToGround(Vector3 position)
		{
			return default(Vector3);
		}

		public static bool IsAvailableInputMove(Entity entity)
		{
			return false;
		}

		public static bool IsTargetInFrontOf(Entity source, Entity target)
		{
			return false;
		}

		public static float SquareDistance(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static Entity GetTarget(Entity self, Bag<Entity> bag, float viewRange)
		{
			return null;
		}

		public static bool IsInRange(int sourceId, int targetId, float squareRange)
		{
			return false;
		}

		public static bool IsInRangeX(int sourceId, int targetId, float squareRange)
		{
			return false;
		}

		public static bool IsInRange(Entity entity, Entity target, float squareRange)
		{
			return false;
		}

		public static bool IsInRangeX(Entity entity, Entity target, float rangeSqr)
		{
			return false;
		}

		public static bool IsInRange(Vector3 posA, Vector3 posB, float squareRange)
		{
			return false;
		}

		public static Vector3 SpherePosition(Transform transform, CollisionSphere sphere)
		{
			return default(Vector3);
		}

		public static Vector3 SpherePosition(Vector3 centerPoint, CollisionSphere sphere, Vector3 rotate)
		{
			return default(Vector3);
		}

		public static GameObject Spawn(string path)
		{
			return null;
		}

		public static GameObject Spawn(GameObject prefab)
		{
			return null;
		}

		public static GameObject Spawn(GameObject prefab, GameObject parent)
		{
			return null;
		}

		public static GameObject SpawnEffect(string path, Vector3 position, Action<bool, GameObject> callback = null)
		{
			return null;
		}

		public static void Recycle(GameObject o)
		{
		}

		public static void TestModifyStat(ref EntityAbilities abilities)
		{
		}

		public static void DropSoulToMainCharacter(Vector3 dropPos, int numOfSoul = 0)
		{
		}

		public static void DropSoul(Vector3 dropPos, Vector3 targetOffset, Transform target, int numOfSoul = 0)
		{
		}

		public static void DropSoul2ToMainCharacter(Vector3 dropPos, int numOfSoul = 0)
		{
		}

		public static void DropSoul2(Vector3 dropPos, Vector3 targetOffset, Transform target, int numOfSoul = 0)
		{
		}

		public static Vector3 GetPositionAtTime(Vector3 startPos, Vector3 velocityStart, float gravity, float time)
		{
			return default(Vector3);
		}

		public static bool IsTheFrontOfIsMapBoundary(Entity entity, Entity camera)
		{
			return false;
		}

		public static bool IsTargetInRange(Entity self, Entity target, Vector2 posOffset, Vector2 hitBoxSize, bool checkTargetInFrontOf)
		{
			return false;
		}

		public static bool IsTargetInRange(Direction selfDirection, Vector3 selfPos, Vector3 targetPos, Vector2 posOffset, Vector2 hitBoxSize)
		{
			return false;
		}

		public static bool IsOnAir(float positionY)
		{
			return false;
		}

		public static Direction GetDirectionToTarget(Entity self, Entity target)
		{
			return default(Direction);
		}

		public static GameObject InstantiateBattlePetView(GameObject parent)
		{
			return null;
		}

		public static bool IsUsePvPPreset(BattleMode battleMode)
		{
			return false;
		}

		public static Preset GetPreset(IBattleModeLogic battleMode)
		{
			return default(Preset);
		}

		public static int GetHpPotionQuantity()
		{
			return 0;
		}

		public static int GetMaxHpPotionQuantity()
		{
			return 0;
		}
	}
}
