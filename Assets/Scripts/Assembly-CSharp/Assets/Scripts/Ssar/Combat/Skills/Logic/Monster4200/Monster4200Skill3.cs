using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4200
{
	public class Monster4200Skill3 : DefaultSpawnerSkill
	{
		public class SkillInfo
		{
			public class Preset
			{
				public List<Vector2> spawnPostions;
			}

			public List<Preset> presets;

			public float padding;
		}

		private SkillInfo info;

		private int presetIndex;

		private int posIndex;

		private List<EventFrame> spawnEventFrames;

		public Monster4200Skill3(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		private void UpdateSpawnPos(EventFrame eventFrame)
		{
		}

		private float ClampXByMap(float x)
		{
			return 0f;
		}
	}
}
