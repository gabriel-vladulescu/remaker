using Artemis;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.HUD;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4201
{
	public class Monster4201Skill1 : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public float suicideTime;
		}

		private SkillInfo info;

		private Entity entity;

		private float explodeDelay;

		private HUDTextInfo hudTextInfo;

		public Monster4201Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override DamageSource GetDamageSource()
		{
			return default(DamageSource);
		}

		protected override void OnUpdate(float dt)
		{
		}

		private void Suicide()
		{
		}
	}
}
