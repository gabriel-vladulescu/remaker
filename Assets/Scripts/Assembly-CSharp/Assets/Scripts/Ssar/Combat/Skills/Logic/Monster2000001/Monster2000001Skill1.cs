using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster2000001
{
	public class Monster2000001Skill1 : DefaultRangerSkill
	{
		public class SkillInfo
		{
			[Serializable]
			public class Pack : InfoElement
			{
				public int projectileCount;

				public float gapBetweenProjectile;

				public float Width => 0f;
			}

			[Serializable]
			public class Row : InfoElement
			{
				public int packCount;

				public float gapBetweenPack;

				public RowSpawnMode spawnMode;

				public float spawnDuration;

				public PickingMode packPickingMode;

				public string packList;

				public List<int> GetPackList()
				{
					return null;
				}
			}

			[Serializable]
			public class Wave : InfoElement
			{
				public float startupTime;

				public Vector2 center;

				public Vector2 size;

				public int randomStep;

				public int rowCount;

				public float interval;

				public PickingMode rowPickingMode;

				public string rowList;

				public float delaySpawnProjectile;

				public float delayLaunchProjectile;

				public bool isShowGizmos;

				public int startupFrameIndex;

				public List<int> GetRowList()
				{
					return null;
				}
			}

			[Serializable]
			public class InfoElement
			{
			}

			public enum RowSpawnMode
			{
				Instant = 0,
				LeftToRight = 1,
				RightToLeft = 2,
				CenterToSide = 3,
				SideToCenter = 4
			}

			public enum PickingMode
			{
				Random = 0,
				RandomInList = 1,
				Sequential = 2
			}

			public List<InfoElement> packs;

			public List<InfoElement> rows;

			public List<InfoElement> waves;
		}

		private class RowTempData
		{
			public float anchorSpawn;

			public float spawnLength;

			public bool reversedSpawn;
		}

		private class CustomMelee : DefaultMeleeSkill
		{
			private readonly Monster2000001Skill1 mainSkill;

			public CustomMelee(Monster2000001Skill1 mainSkill, Dependencies dependencies)
				: base(null)
			{
			}

			protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
			{
			}

			protected override void OnProjectileFinishEvent(Projectile projectile)
			{
			}
		}

		private class CustomTrajectory : Projectile.Trajectory
		{
			private readonly float standbyTime;

			private float elapsedTime;

			private Vector3 startPos;

			public CustomTrajectory(float standbyTime)
			{
			}

			public Direction AdjustCharacterFacingDirectionParam(Direction currentDirection, Direction directionAtTheTimeOfFirstProjectileCreation)
			{
				return default(Direction);
			}

			public Vector3 AdjustCharacterPositionParam(Vector3 currentCharacterPosition, Vector3 characterPositionAtTheTimeOfFirstProjectileCreation)
			{
				return default(Vector3);
			}

			public void Update(float dt, Projectile projectile, Vector3 currentPosition)
			{
			}
		}

		private class Spawner
		{
			private readonly Monster2000001Skill1 skill;

			private readonly SkillInfo.Wave wave;

			private float intervalTime;

			private int rowCount;

			private float elasped;

			public Spawner(Monster2000001Skill1 skill, SkillInfo.Wave wave)
			{
			}

			public void Update(float dt)
			{
			}

			private SkillInfo.Row GetRow()
			{
				return null;
			}

			private SkillInfo.Pack GetPack(SkillInfo.Row row, int packIndex)
			{
				return null;
			}

			private RowTempData GetRowSpawnTempData(SkillInfo.Row row, float centerX, float width)
			{
				return null;
			}

			private float GetSpawnTime(SkillInfo.Row row, RowTempData tempData, float x)
			{
				return 0f;
			}

			private void SpawnProjectileWave()
			{
			}

			private void SpawnRow(Vector2 centerPos)
			{
			}

			private void SpawnPack(SkillInfo.Row row, SkillInfo.Pack pack, Vector2 centerPos, RowTempData rowTempData)
			{
			}
		}

		private SkillInfo info;

		private EventFrame damageEventFrame;

		private EventFrame vfxEventFrame;

		private List<EventFrame> vfxStartupEventFrame;

		private EventFrame vfxBreakEventFrame;

		private Spawner[] spawners;

		private CustomMelee meleeSkill;

		private Dictionary<EventFrame, Vector3> mappingVfxPositions;

		private Dictionary<EventFrame, float> mappingProjectileDelayLaunch;

		private Dictionary<EventFrame, EventFrame> mappingVfxFrameToMeleeFrame;

		private Dictionary<EventFrame, GameObject> mappingMeleeFrameToVfxObjects;

		public Monster2000001Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override bool UseCharacterFacingDirectionForCalculatingProjectileSpawnPosition()
		{
			return false;
		}

		protected override void OnAfterVfxPlayed(EventFrame ef, GameObject vfx)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		private EventFrame SpawnProjectile(Vector2 pos, float time, float delay)
		{
			return null;
		}

		private EventFrame SpawnVfx(Vector3 pos, EventFrame source, float frame)
		{
			return null;
		}

		private void DespawnMeleeVfx(EventFrame meleeFrame, Vector3 position)
		{
		}
	}
}
