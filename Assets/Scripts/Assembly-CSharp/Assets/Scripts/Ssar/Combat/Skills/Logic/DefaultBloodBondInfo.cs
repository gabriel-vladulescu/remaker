using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultBloodBondInfo : BloodBondModifier.Info
	{
		private float successRate;

		private float duration;

		private float damageScale;

		private float interval;

		private bool isLifeCycleDependOnParentSkill;

		private Vector3[] path;

		private Projectile casterProjectile;

		private string[] jointNames;

		private DamageType damageType;

		public DefaultBloodBondInfo(float successRate, float duration, float damageScale, float interval, bool isLifeCycleDependOnParentSkill, Vector3[] path, Projectile casterProjectile, string jointNamesRaw, DamageType damageType)
		{
		}

		public float SuccessRate()
		{
			return 0f;
		}

		public float Duration()
		{
			return 0f;
		}

		public float DamageScale()
		{
			return 0f;
		}

		public float Interval()
		{
			return 0f;
		}

		public Vector3[] Path()
		{
			return null;
		}

		public Projectile CasterProjectile()
		{
			return null;
		}

		public bool IsLifeCycleDependOnParentSkill()
		{
			return false;
		}

		public string[] JointNames()
		{
			return null;
		}

		public DamageType DamageType()
		{
			return default(DamageType);
		}
	}
}
