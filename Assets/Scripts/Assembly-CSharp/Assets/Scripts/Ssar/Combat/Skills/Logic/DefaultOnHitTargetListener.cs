using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultOnHitTargetListener : OnHitTargetListener
	{
		private string skillId;

		private EntityWorld entityWorld;

		public DefaultOnHitTargetListener(string skillId, EntityWorld entityWorld)
		{
		}

		public void OnHitTarget(Character caster, List<Character> targets)
		{
		}
	}
}
