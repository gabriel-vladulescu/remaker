using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.System.Input.Model
{
	public class CharacterInput : UserInput
	{
		public AbsRequest RunRequest;

		public DashRequest DashRequest;

		public JumpRequest JumpRequest;

		private bool isRun;

		private bool isDash;

		private bool isJump;

		private bool isAttack;

		private bool isChangeDirection;

		protected List<bool> isInputSkills = new List<bool>();

		protected List<string> skillIds = new List<string>();

		private bool autoReleaseRunInputAfterExcute;

		protected int processingSkillCastingRequestId;

		protected int requestId;

		private int dashInputFrame;

		public void Run(AbsRequest runRequest, bool autoReleaseAfterExcute = false)
		{
			RunRequest = runRequest;
			isRun = runRequest != null;
			autoReleaseRunInputAfterExcute = autoReleaseAfterExcute;
		}

		public void ReleaseRunInput()
		{
			RunRequest = null;
			isRun = false;
		}

		public void SetAutoReleaseRunInputAfterExcute(bool autoRelease)
		{
			autoReleaseRunInputAfterExcute = autoRelease;
		}

		public void Dash(DashRequest dashRequest, int frame)
		{
			DashRequest = dashRequest;
			isDash = dashRequest != null;
			dashInputFrame = frame;
		}

		public void ReleaseInputDash()
		{
			DashRequest = null;
			isDash = false;
		}

		public int GetDashInputFrame()
		{
			return dashInputFrame;
		}

		public void Jump(JumpRequest jumpRequest)
		{
			JumpRequest = jumpRequest;
			isJump = jumpRequest != null;
		}

		public void ReleaseInputJump()
		{
			JumpRequest = null;
			isJump = false;
		}

		public void Attack()
		{
			isAttack = true;
		}

		public void ReleaseInputAttack()
		{
			isAttack = false;
		}

		public void SetIsChangeDirection(bool isChangeDirection)
		{
			this.isChangeDirection = isChangeDirection;
		}

		public virtual bool CastSkill(int skillOrder, string skillId)
		{
			return false;
		}

		public virtual void OnSkillCastingRequestConsumed()
		{
		}

		public bool IsHoldingAttack()
		{
			return isAttack;
		}

		protected bool IsProcessingSkillCastingRequest()
		{
			return false;
		}

		protected void AutoResizeSkillIds(int skillOrder)
		{
		}

		protected void AutoResizeInputSkills(int skillOrder)
		{
		}

		public virtual void ReleaseCastSkill(int skillOrder)
		{
		}

		public bool IsInputRun()
		{
			return isRun;
		}

		public bool IsInputDash()
		{
			return isDash;
		}

		public bool IsInputJump()
		{
			return isJump;
		}

		public bool IsInputAttack()
		{
			return isAttack;
		}

		public bool IsAutoReleaseRunInputAfterExcute()
		{
			return autoReleaseRunInputAfterExcute;
		}

		public virtual bool IsInputSkill()
		{
			for (int i = 0; i < isInputSkills.Count; i++)
			{
				if (isInputSkills[i])
				{
					return true;
				}
			}
			return false;
		}

		public string SkillId()
		{
			for (int i = 0; i < isInputSkills.Count; i++)
			{
				if (isInputSkills[i])
				{
					return skillIds[i];
				}
			}
			return null;
		}

		public bool IsChangeDirection()
		{
			return isChangeDirection;
		}

		public bool IsInputRunInOppositeDirection()
		{
			return isRun && isChangeDirection;
		}

		public void ReleaseAllInput()
		{
			ReleaseRunInput();
			ReleaseInputDash();
			ReleaseInputJump();
			ReleaseInputAttack();
		}
	}
}
