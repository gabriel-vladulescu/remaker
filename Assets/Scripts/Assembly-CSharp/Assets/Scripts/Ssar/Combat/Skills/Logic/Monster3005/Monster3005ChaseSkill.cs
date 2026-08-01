using Artemis;
using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster3005
{
	public class Monster3005ChaseSkill : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public float speed;

			public float minAmplitude;

			public float maxAmplitude;

			public float minPeriod;

			public float maxPeriod;

			public int randomDensity;
		}

		private SkillInfo info;

		private Entity casterEntity;

		private Character target;

		private Entity targetEntity;

		private float amplitude;

		private float period;

		public Monster3005ChaseSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		private void CacheData()
		{
		}

		private void FindTarget()
		{
		}

		private bool IsTargetValid()
		{
			return false;
		}

		private Vector3 GetDirection()
		{
			return default(Vector3);
		}

		private Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		private void ProcessMove(float dt)
		{
		}
	}
}
