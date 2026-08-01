using System.Collections.Generic;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public interface OnHitTargetListener
	{
		void OnHitTarget(Character caster, List<Character> targets);
	}
}
