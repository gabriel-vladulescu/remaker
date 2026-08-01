using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character1Skill6Version2 : DefaultMeleeSkill
	{
		private class Tracker
		{
			private float ROTATION_DURATION_IN_SECONDS;

			private Environment environment;

			private WeaponVfxInfo2 weaponVfxInfo;

			private Character1Skill6Version2Info projectileMovementInfo;

			private Vector2 casterPos;

			private int casterFacingDirection;

			private Vector2 spawnPos;

			private Vector2 centerPos;

			private Transform weapon;

			private bool spawned;

			private bool isFlying;

			private GameObject vfx;

			private GameObject vfxContainer;

			private GameObject vfxWeapon;

			private GameObject vfxWeaponContainer;

			private double finalAngleInRad;

			private Vector2 direction;

			private float distance;

			private float elapsedFlying;

			private bool isFinish;

			private float speed;

			private float elapsed;

			private Quaternion vfxOriginalQuaternion;

			private float elapsedScale;

			private bool isScaling;

			public Tracker(Environment environment, WeaponVfxInfo2 weaponVfxInfo, Character1Skill6Version2Info projectileMovementInfo, Vector2 casterPos, int casterFacingDirection, Vector2 spawnPos, Vector2 centerPos, Transform weapon)
			{
			}

			public void Update(float dt)
			{
			}

			private void SpawnVfx()
			{
			}
		}

		private Character1Skill6Version2Info info;

		private Environment environment;

		private EntityWorld entityWorld;

		private float elapsed;

		private List<Tracker> trackers;

		private MainCharacterData mainCharacterData;

		public Character1Skill6Version2(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		private List<Vector2> GenerateSpawnPos(Vector2 center, float radius, int count, float angle)
		{
			return null;
		}

		private List<Vector2> GenerateNormalizedRays(int count, float angle)
		{
			return null;
		}
	}
}
