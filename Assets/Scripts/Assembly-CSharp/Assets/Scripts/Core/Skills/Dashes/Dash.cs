using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Dashes
{
	public class Dash
	{
		private readonly EventFrame ef;

		private readonly Character caster;

		private CharacterMediatorComponent characterMediatorComponent;

		private float duration;

		private float elapsed;

		private BoxCollider casterBoxCollider;

		private bool ignoreMinSpeedOnAir;

		public bool IgnoreMinSpeedOnAir
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Dash(EventFrame ef, Character caster, bool ignoreMinSpeedOnAir)
		{
		}

		public void Update(float dt)
		{
		}

		public void Interrupt()
		{
		}

		private void ResetColliderToOriginalValues()
		{
		}

		private void ResizeCollider(EventFrame ef)
		{
		}

		private void CacheOriginalColliderData(EventFrame ef, Character caster)
		{
		}

		private void PerformDash(EventFrame ef, Character caster)
		{
		}

		private bool IsFinish()
		{
			return false;
		}
	}
}
