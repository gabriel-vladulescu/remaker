using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4007
{
	public class Monster4007Skill1 : DefaultSpawnerSkill
	{
		public class SkillInfo
		{
			public int maxMonster;

			public float minInterval;

			public float maxInterval;

			public List<float> spawnIntervals;
		}

		private SkillInfo info;

		private EventFrame vfxFrame;

		private EventFrame onMobVfxFrame;

		private List<GameObject> spawnedMonster;

		private float spawnTime;

		private int spawnedCount;

		private Dictionary<EventFrame, Vector3> onMobVfxPos;

		public Monster4007Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void UpdateSpawn(float dt)
		{
		}

		protected override void OnSpawn(EventFrame ef, GameObject obj)
		{
		}

		protected override void OnVfxPlayed(EventFrame ef, GameObject obj)
		{
		}

		private float GetInterval()
		{
			return 0f;
		}

		private void PlaySpawnEffect()
		{
		}
	}
}
