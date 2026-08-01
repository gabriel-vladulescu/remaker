using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster3100
{
	public class GateOfBabylonDependencies
	{
		public DefaultRangerSkill baseSkill;

		public Character caster;

		public EventFrame projectileEventFrame;

		public EventFrame gateVfxEventFrame;

		public EventFrame startupProjectileVfxEventFrame;

		public GateOfBabylonDependencies(DefaultRangerSkill baseSkill, Character caster, EventFrame projectileEventFrame, EventFrame gateVfxEventFrame, EventFrame startupProjectileVfxEventFrame)
		{
		}
	}
}
