using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster9010
{
	public class Monster9010Skill1 : DefaultSpawnerSkill
	{
		public class SkillInfo
		{
			public float minInterval;

			public float maxInterval;
		}

		private SkillInfo info;

		private bool canSpawn;

		private Dictionary<EventFrame, GameObject> spawnedMonster;

		private Dictionary<EventFrame, float> spawnedDelay;

		public Monster9010Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnSpawn(EventFrame ef, GameObject obj)
		{
		}

		public override void Interrupt()
		{
		}

		private float GetInterval()
		{
			return 0f;
		}
	}
}
