using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Gizmo;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultAuraSkill : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public float auraInterval;

			public float activeFrame;

			public float duration;
		}

		protected SkillInfo info;

		private List<EventFrame> buffEventFrames;

		private float interval;

		private readonly float activeTime;

		private readonly float deactiveTime;

		protected bool isInitBuffDone;

		private Dictionary<GizmoDrawRequest, Vector3> gizmoDrawRequests;

		public DefaultAuraSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		private void ActivateBuffs()
		{
		}

		protected virtual void ActivateBuff(EventFrame buffEventFrame)
		{
		}

		private void ActivateGizmo(EventFrame ef)
		{
		}

		private void UpdateGizmo(float dt)
		{
		}
	}
}
