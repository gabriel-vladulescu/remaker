using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class BloodBondModifier : ShackleModifier
	{
		public interface Info
		{
			float SuccessRate();

			float Duration();

			float DamageScale();

			float Interval();

			Vector3[] Path();

			Projectile CasterProjectile();

			bool IsLifeCycleDependOnParentSkill();

			string[] JointNames();

			DamageType DamageType();
		}

		private class ShackleInfoAdapter : ShackleInfo
		{
			private Info info;

			public ShackleInfoAdapter(Info info)
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

			public bool PlayVfx()
			{
				return false;
			}

			public string GetVfxPath()
			{
				return null;
			}
		}

		private readonly Info info;

		private readonly Entity caster;

		private readonly Entity target;

		private HealthComponent healthComponent;

		private Character targetCharacter;

		private Vector3 hookPos;

		private float elapsedSinceLastDamage;

		private GameObject coreFx;

		private List<Vector3> linkPos;

		private List<GameObject> linkFXs;

		private List<Projectile> casterProjectiles;

		private int stackCount;

		public BloodBondModifier(Info info, Entity caster, Entity target)
			: base(null, null)
		{
		}

		public override string Name()
		{
			return null;
		}

		public override ModifierType Type()
		{
			return default(ModifierType);
		}

		public override void Update(float dt)
		{
		}

		public override void OnReplaceOtherModifiers(Character character, List<Modifier> others)
		{
		}

		public override void OnAttach(Character character)
		{
		}

		public override void OnDetach(Character character)
		{
		}

		public override object[] Cookies()
		{
			return null;
		}

		public override bool IsFinish()
		{
			return false;
		}

		public bool IsCastedByProjectile(Projectile projectile)
		{
			return false;
		}

		private void SetupLinkPositions()
		{
		}

		private Transform GetJoint()
		{
			return null;
		}

		private void PlayCoreFx()
		{
		}

		private void PlayLinkFX()
		{
		}

		private void ClearVfx()
		{
		}

		private void ReturnVfxToPool(GameObject vfx)
		{
		}
	}
}
