using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75006
{
	public class Monster75006Skill2 : DefaultMeleeSkill
	{
		public class Info
		{
			public float spawnY;
		}

		private Info info;

		private EventFrame damageFrame;

		private List<EventFrame> vfxFrames;

		private Dictionary<EventFrame, Vector2> mappingVfxPositions;

		public Monster75006Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		private void SpawnEater()
		{
		}

		private Vector3 GetTargetRelativePosition()
		{
			return default(Vector3);
		}

		private void SpawnDamage(Vector2 pos)
		{
		}

		private void SpawnVfx(Vector2 centerPos)
		{
		}
	}
}
