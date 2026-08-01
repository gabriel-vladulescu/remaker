using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class MeleeDamage : Damage
	{
		private Vector2 meleeDimension;

		private float meleeRotation;

		private float hitboxRadius;

		private int meleeNumberOfHit;

		private float meleeIntervalBetweenHit;

		private string[] meleeIgnoreWhileSkillIdsAreUsing;

		private GameObject meleeNotificationVfxPrefab;

		private GameObject meleeImpactVfxPrefab;

		private float ignoreDefChance;

		private bool meleeIgnoreHeroPosOnYAxis;

		private readonly bool standstillAfterCreation;

		private readonly bool showTrueGizmo;

		public float MeleeRotation => 0f;

		public float HitboxRadius => 0f;

		public int MeleeNumberOfHit => 0;

		public float MeleeIntervalBetweenHit => 0f;

		public string[] MeleeIgnoreWhileSkillIdsAreUsing => null;

		public GameObject MeleeNotificationVfxPrefab => null;

		public GameObject MeleeImpactVfxPrefab => null;

		public float IgnoreDefChance => 0f;

		public bool MeleeIgnoreHeroPosOnYAxis => false;

		public bool StandstillAfterCreation => false;

		public bool ShowTrueGizmo => false;

		public MeleeDamage(ProjectileType projectileType, int projectileCount, bool shouldTriggerOnHitTarget, bool shouldTriggerOnHitTargetWithFirstHitOnly, bool isWindbox, float damageMultiplier, float timeToLive, HitboxParams hitboxParams, HitboxPositionParams hitboxPositionParams, Vector2 meleeDimension, float meleeRotation, float hitboxRadius, int meleeNumberOfHit, float meleeIntervalBetweenHit, string[] meleeIgnoreWhileSkillIdsAreUsing, GameObject meleeNotificationVfxPrefab, GameObject meleeImpactVfxPrefab, float delayHandleObstacleCollision, float delayHandleObjectCollision, HitboxModifiers hitboxModifiers, ProjectileTrajectoryParams trajectoryParams, float ignoreDefChance, bool meleeIgnoreHeroPosOnYAxis, bool standstillAfterCreation, bool showTrueGizmo)
			: base(default(ProjectileType), 0, shouldTriggerOnHitTarget: false, shouldTriggerOnHitTargetWithFirstHitOnly: false, isWindbox: false, 0f, 0f, null, null, 0f, 0f, null, null)
		{
		}

		public Vector2 MeleeDimension()
		{
			return default(Vector2);
		}
	}
}
