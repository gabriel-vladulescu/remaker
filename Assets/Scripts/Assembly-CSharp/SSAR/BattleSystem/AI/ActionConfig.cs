using System;
using System.Collections.Generic;
using SSAR.BattleSystem.Input;
using Ssar.BattleSystem.AISystem.Condition;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class ActionConfig : ICloneable
	{
		public ActionName actionName;

		public string mobType;

		[Action("Action Level", null)]
		public AIExcuteLevel actionLevel;

		[Action("Flag Enable", null)]
		public AIFlag flagEnable;

		[Action("Id", null)]
		public int id;

		[Action("Score", null)]
		public float score;

		[Action("Basic Point", null)]
		public float[] basicPoint;

		[Action("Startup Time", "s")]
		public float[] originalStartupTime;

		[Action("Local Cooldown", "s")]
		public float originalLocalCooldown;

		[Action("Global Cooldown", "s")]
		public float globalCooldown;

		[Action("Action Duration", null)]
		public float[] originalDuration;

		[Action("Life Time", "/s")]
		public float totalTime;

		[Action("Enable Action", null)]
		public bool enableAction;

		[Action("ActionId", null)]
		public float actionId;

		[Action("Range", null)]
		public float[] range;

		[Action("Delay Get Target", null)]
		public float delayOverrideTarget;

		[Action("Check Is InFrontOf", null)]
		public bool checkisInFrontOf;

		[Action("Warning Effect", null)]
		public ActionWarningEffect warningEffect;

		[Action("Bypass Check Can Input", null)]
		public bool bypassCheckState;

		[Action("Play Fx", null)]
		public bool playFx;

		[Action("Movement", null)]
		public List<MovementInfo> movement;

		[SerializeField]
		[Action("MaterialFloat", null)]
		public AIMaterialColorEffect materialColorEffect;

		[Action("MaterialColor", null)]
		[SerializeField]
		public AIMateralFloatEfect materialFloatEffect;

		[Action("Override Target", null)]
		public bool overrideTarget;

		[Action("Change Face", null)]
		public bool changeFaceDirection;

		[Action("Interval", "s")]
		public float interval;

		[Action("Amplitude", "m")]
		public float amplitude;

		[Action("VerticalSpeed", "m/s")]
		public float verticalSpeed;

		[Action("OffsetWithHead", "m")]
		public float[] offsetWithHead;

		[Action("BackwardY", null)]
		public float[] backwardY;

		[Action("Range X", null)]
		public float[] rangeX;

		[Action("Range Y", null)]
		public float[] rangeY;

		[Action("Reverse", null)]
		public bool reverse;

		[Action("No Target In RangeX", null)]
		public float noTargetInRangeX;

		[Action("Has Target In RangeX", null)]
		public float hasTargetInRangeX;

		[Action("Has Target In RangeY", null)]
		public float hasTargetInRangeY;

		[Action("Skill Id", null)]
		public int skillId;

		[Action("Change Direction One Time", null)]
		public bool changeDirectionOneTime;

		[Action("Cooldown All Skill After Excute", "s")]
		public float cooldownAllSkill;

		[Action("Rate", "%")]
		public float rate;

		[Action("PosOffset", null)]
		public Vector2 posOffset;

		[Action("Hitbox Size", "%")]
		public Vector2 hitBoxSize;

		[Action("Disable Approach Target", null)]
		public bool disableApproachTarget;

		[Action("Enable Jump", null)]
		public bool enableJump;

		[Action("Change Direction To Target", null)]
		public bool changeDirectionToTarget;

		[Action("Approach Target", null)]
		public bool approachTarget;

		[Action("DistanceToEdgeChangeDirection", null)]
		public float distanceToEdgeChangeDirection;

		[Action("Skill Id Text", null)]
		public string skillIdText;

		[Action("Action Type", null)]
		public ActionType actionType;

		[Action("Action On Exit", null)]
		public ActionType actionTypeExit;

		[Action("Bypass Skill State", null)]
		public bool bypassSkillState;

		[Action("Change Direction Left Target", null)]
		public bool changeDirectionMoveLeftTarget;

		[Action("Rate Approach", "%")]
		public float rateApproach;

		[Action("Move Right", null)]
		public bool moveRight;

		[Action("Turn Right", null)]
		public bool turnRight;

		[Action("Turn Back", null)]
		public bool turnBack;

		[SerializeField]
		public List<AIBuffConfig> buff;

		[SerializeField]
		public List<ActionTriggerConfig> trigger;

		[SerializeField]
		public List<TargetScore> group;

		[SerializeField]
		public List<TargetScore> tag;

		[SerializeField]
		public List<ConditionConfig> awakeConditions;

		[SerializeField]
		public List<ConditionConfig> exitConditionConfigs;

		public ActionConfig(string mobType, ActionName name)
		{
		}

		public List<string> GetListPropertyAvailable()
		{
			return null;
		}

		public void AddBuff(AIBuffConfig config)
		{
		}

		public void AddTrigger(ActionTriggerConfig config)
		{
		}

		public void RemoveTrigger(ActionTriggerConfig config)
		{
		}

		public void RemoveBuff(AIBuffConfig config)
		{
		}

		public void InitDefaultScore()
		{
		}

		public void AddAwakeCondition(ConditionConfig config)
		{
		}

		public void RemoveAwakeCondition(ConditionConfig config)
		{
		}

		public void AddExitCondition(ConditionConfig config)
		{
		}

		public void RemoveExitCondition(ConditionConfig config)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
