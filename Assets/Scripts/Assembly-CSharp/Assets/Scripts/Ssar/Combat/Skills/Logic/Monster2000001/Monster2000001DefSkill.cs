using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster2000001
{
	public class Monster2000001DefSkill : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public float delayTransform;

			public float delayDetransform;

			public string breakAnimName;

			public float delayPlayBreakAnim;

			public int frameAnimDetransform;
		}

		private readonly SkillInfo info;

		private List<GameObject> stoneObj;

		private SkeletonAnimation stoneSkeletonAnimation;

		private bool playedBreak;

		private bool isTransformed;

		private bool isDetransformed;

		private readonly float scaleTime;

		public Monster2000001DefSkill(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		private void ForceDetransform()
		{
		}
	}
}
