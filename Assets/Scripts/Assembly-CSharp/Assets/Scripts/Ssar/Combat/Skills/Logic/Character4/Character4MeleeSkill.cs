using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character4
{
	public class Character4MeleeSkill : DefaultMeleeSkill
	{
		private Dictionary<Assets.Scripts.Core.Skills.Modifiers.ModifierType, bool> whiteList;

		private List<EventFrame> processedEventFrames;

		public Character4MeleeSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override bool IsInterruptibleWhileChanneling()
		{
			return false;
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}
	}
}
