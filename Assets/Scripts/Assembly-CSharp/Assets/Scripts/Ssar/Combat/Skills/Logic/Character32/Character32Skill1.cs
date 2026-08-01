using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character32
{
	public class Character32Skill1 : DefaultMeleeSkill
	{
		public class Info
		{
			public string arcaneHairGameObjectName;

			public string arcaneHairIdleAnimationName;

			public string arcaneHairAttackAnimationName;

			public string arcaneRayLoopSfxPath;

			public string arcaneRayRecoverySfxPath;

			public float arcaneRayLoopSfxFadeoutDuration;
		}

		private static string arcaneHairGameObjectName;

		private static string arcaneHairAttackAnimationName;

		private static string arcaneHairIdleAnimationName;

		private Info info;

		private bool isInterrupted;

		private bool isHairAttackAnimationPlayed;

		private GameObject arcaneHair;

		private Animation arcaneHairAnimationComponent;

		private List<GameObject> vfxs;

		private Direction previousFacingDirection;

		private Vector3 localPosition;

		private Quaternion localRotation;

		private Vector3 localScale;

		private bool isLoopSfxPlayed;

		private AudioClip arcaneLoopAudioClip;

		public Character32Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override bool IsFinish()
		{
			return false;
		}

		public override bool IsChannelingFinish()
		{
			return false;
		}

		public override void OnFinish(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		public override bool IsMoveable()
		{
			return false;
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}
	}
}
