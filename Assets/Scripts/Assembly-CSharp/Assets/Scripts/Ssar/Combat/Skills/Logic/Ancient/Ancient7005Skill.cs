using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Ancient
{
	public class Ancient7005Skill : DefaultRangerSkill
	{
		public class SkillInfo
		{
			public float maxRange;

			public float interval;
		}

		private class VfxFollowTransform
		{
			public GameObject vfx;

			public Transform target;

			public VfxFollowTransform(GameObject vfx, Transform target)
			{
			}
		}

		private SkillInfo info;

		private EventFrame vfxEventFrame;

		private VfxAncient7005Controller vfxController;

		private Character target;

		private AttackComponent casterAtkComp;

		private AttackComponent targetAtkComp;

		private HealthComponent casterHealthComp;

		private HealthComponent targetHealthComp;

		private CachingComponent casterCachingComp;

		private CachingComponent targetCachingComp;

		private float casterAttackBonus;

		private float casterDefBonus;

		private float targetAttackBonus;

		private float targetDefBonus;

		private int stackCount;

		private GameObject linkVfxObj;

		private List<VfxFollowTransform> headVfxObjs;

		private int targetIndex;

		private float interval;

		private float activeTime;

		private float linkDuration;

		private bool linkBreaked;

		public Ancient7005Skill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override void OnAfterVfxPlayed(EventFrame ef, GameObject vfx)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		private void Activate(Character target)
		{
		}

		private void PlayOnHeadVfx(Entity entity, EffectPathIndex epi, bool isTarget)
		{
		}

		private bool IsValidRange()
		{
			return false;
		}

		private bool IsValidTarget()
		{
			return false;
		}

		private void UpdateStats()
		{
		}

		private void ResetStats()
		{
		}

		private void UpdateLink()
		{
		}

		private void RemoveHeadVfxs()
		{
		}

		private void RemoveVfx(GameObject vfx)
		{
		}
	}
}
