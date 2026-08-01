using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Skills.Logic.AnimationControl;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster3100
{
	public class Monster3100Skill1 : DefaultRangerSkill
	{
		public class SkillInfo
		{
			public class AnimationConfig
			{
				public float startLoopTime;

				public float recoveryTime;

				public string animLoop;

				public string animRecovery;
			}

			public SkillAnimationConfig animConfig;

			public List<GateOfBabylonConfig> gates;
		}

		private SkillInfo skillInfo;

		private EventFrame projectileEventFrame;

		private EventFrame gateVfxEventFrame;

		private EventFrame startupProjectileVfxEventFrame;

		private List<GateOfBabylon> gates;

		private SkillAnimationController animController;

		public Monster3100Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		private GateOfBabylonDependencies GetGateDependencies()
		{
			return null;
		}
	}
}
