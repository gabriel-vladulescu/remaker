using Artemis;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class CharacterJump : Hero
	{
		public int jumpCharge;

		private int maxJumpCharge;

		private Entity entity;

		private int groupId;

		private int subId;

		private int level;

		private int remainingJumpAttack1Charge;

		private int maxJumpAttack1Charge;

		public CharacterJump(Entity entity, int maxJumpCharge)
		{
			this.entity = entity;
			this.maxJumpCharge = maxJumpCharge;
			jumpCharge = maxJumpCharge;
			remainingJumpAttack1Charge = 1;
			maxJumpAttack1Charge = 1;
		}

		public bool HasEnoughJumpCharge()
		{
			return jumpCharge > 0;
		}

		public void ConsumeJumpCharge()
		{
			if (jumpCharge > 0)
			{
				jumpCharge--;
			}
		}

		public void ConsumeJumpAttack1Charge()
		{
			if (remainingJumpAttack1Charge > 0)
			{
				remainingJumpAttack1Charge--;
			}
		}

		public void RecoverCharge()
		{
			jumpCharge = maxJumpCharge;
			remainingJumpAttack1Charge = maxJumpAttack1Charge;
		}

		public int JumpOrder()
		{
			return maxJumpCharge - jumpCharge;
		}

		public Vector3 Position()
		{
			CharacterMediatorComponent mediator = entity != null ? entity.GetComponent<CharacterMediatorComponent>() : null;
			return mediator != null ? mediator.Position : Vector3.zero;
		}

		public Entity Entity()
		{
			return entity;
		}

		public int FacingDirection()
		{
			MovementComponent mc = entity != null ? entity.GetComponent<MovementComponent>() : null;
			return mc != null ? (int)mc.Direction : (int)Direction.Right;
		}

		public string Group()
		{
			return groupId + "_" + subId;
		}

		public int GetAttackPower()
		{
			return 0;
		}

		public void FaceOppositeDirection()
		{
			MovementComponent mc = entity != null ? entity.GetComponent<MovementComponent>() : null;
			if (mc != null)
			{
				mc.UpdateDirection(mc.Direction == Direction.Right ? Direction.Left : Direction.Right);
			}
		}

		public bool IsComboAttack2Available()
		{
			return true;
		}

		public bool IsComboAttack3Available()
		{
			return true;
		}

		public bool IsComboAttack4Available()
		{
			return true;
		}

		public bool IsDashAttackAvailable()
		{
			return true;
		}

		public bool IsJumpAttack1Available()
		{
			return remainingJumpAttack1Charge > 0;
		}

		public bool IsJumpAttack2Available()
		{
			return true;
		}

		public bool IsDashAvailable()
		{
			MovementComponent mc = entity != null ? entity.GetComponent<MovementComponent>() : null;
			return mc != null && mc.CanDash();
		}

		public bool IsJumpAvailable()
		{
			return HasEnoughJumpCharge();
		}
	}
}
