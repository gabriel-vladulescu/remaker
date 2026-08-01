using Artemis;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	internal class TestHero : Hero
	{
		private int remainingCharge;

		public bool HasEnoughJumpCharge()
		{
			return false;
		}

		public void ConsumeJumpCharge()
		{
		}

		public void ConsumeJumpAttack1Charge()
		{
		}

		public void RecoverCharge()
		{
		}

		public int JumpOrder()
		{
			return 0;
		}

		public Vector3 Position()
		{
			return default(Vector3);
		}

		public Entity Entity()
		{
			return null;
		}

		public int FacingDirection()
		{
			return 0;
		}

		public string Group()
		{
			return null;
		}

		public int GetAttackPower()
		{
			return 0;
		}

		public void FaceOppositeDirection()
		{
		}

		public bool IsComboAttack2Available()
		{
			return false;
		}

		public bool IsComboAttack3Available()
		{
			return false;
		}

		public bool IsComboAttack4Available()
		{
			return false;
		}

		public bool IsDashAttackAvailable()
		{
			return false;
		}

		public bool IsJumpAttack1Available()
		{
			return false;
		}

		public bool IsJumpAttack2Available()
		{
			return false;
		}

		public bool IsDashAvailable()
		{
			return false;
		}

		public bool IsJumpAvailable()
		{
			return false;
		}
	}
}
