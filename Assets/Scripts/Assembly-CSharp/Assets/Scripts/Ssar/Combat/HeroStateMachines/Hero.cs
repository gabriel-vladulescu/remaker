using Artemis;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public interface Hero
	{
		bool HasEnoughJumpCharge();

		void ConsumeJumpCharge();

		void ConsumeJumpAttack1Charge();

		void RecoverCharge();

		int JumpOrder();

		Vector3 Position();

		Entity Entity();

		int FacingDirection();

		string Group();

		int GetAttackPower();

		void FaceOppositeDirection();

		bool IsComboAttack2Available();

		bool IsComboAttack3Available();

		bool IsComboAttack4Available();

		bool IsDashAttackAvailable();

		bool IsJumpAttack1Available();

		bool IsJumpAttack2Available();

		bool IsDashAvailable();

		bool IsJumpAvailable();
	}
}
