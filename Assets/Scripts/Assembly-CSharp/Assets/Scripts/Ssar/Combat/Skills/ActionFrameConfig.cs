using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class ActionFrameConfig
	{
		public int actionType;

		public bool shouldTriggerOnHitTarget;

		public bool shouldTriggerOnHitTargetWithFirstHitOnly;

		public float damageMultiplier;

		public int maxEnemyHitCount;

		public float timeToLive;

		public float delayHandleObstacleCollision;

		public float delayHandleObjectCollision;

		public float hitboxRotation;

		public bool isWindbox;

		public int meleeNumberOfHit;

		public float meleeIntervalBetweenHit;

		public Vector2 meleeRelativePositionToCharacter;

		public Vector2 meleeDimension;

		public float hitboxRadius;

		public bool meleeDrawGizmos;

		public string meleeIgnoreWhileSkillIdsAreUsing;

		[PreloadPool.PrefabPathMarker]
		public string meleeNotificationVfxPrefabPath;

		[PreloadPool.PrefabPathMarker]
		public string meleeImpactVfxPrefabPath;

		public float meleeDefIgnoreChance;

		public bool meleeIgnoreHeroPosOnYAxis;

		public bool meleeStandstillAfterCreation;

		public bool findTargetInFront;

		public string rangerProjectileConfigString;

		[NonSerialized]
		public RangerProjectileConfig rangerProjectileConfig;

		public string hitboxConfigString;

		[NonSerialized]
		public HitboxConfig hitboxConfig;

		public string trajectoryConfigString;

		[NonSerialized]
		public List<ProjectileTrajectoryConfig> trajectoryConfigs;

		public HitboxModifiersConfig hitboxModifiersConfig;

		public ActionType ActionTypeValue()
		{
			return default(ActionType);
		}

		public string[] IgnoreSkillIdsWhileUsing()
		{
			return null;
		}

		public void OnAfterDeserialize(SkillEventFrameConfig config)
		{
		}
	}
}
