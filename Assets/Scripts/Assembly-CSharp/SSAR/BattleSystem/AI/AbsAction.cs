using System;
using System.Collections.Generic;
using Artemis;
using Artemis.Utils;
using SSAR.BattleSystem.Input;
using Ssar.BattleSystem.AISystem.Condition;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public abstract class AbsAction
	{
		private const int DELAY_CAN_EXIT = 1;

		private const float DELAY_EXCUTE_AFTER_BREAK_ACTION = 0.1f;

		public AIExcuteLevel actionLevel;

		public AIFlag flagEnable;

		public int id;

		public float score;

		public float point;

		public float startupTime;

		public float timeToFinishRecovery;

		public float interuptHp;

		public float[] basicPoint;

		public float[] originalStartupTime;

		public float originalLocalCooldown;

		public float globalCooldown;

		public float randomBasicPoint;

		public bool manualDisable;

		public bool bypassCheckState;

		public bool bypassSkillState;

		public bool forceDisable;

		private float randomStartupTime;

		public AIMaterialColorEffect materialColorEffect;

		public AIMateralFloatEfect materialFloatEffect;

		private float damageTaken;

		private ActionConfig config;

		protected NewMonsterAIComponent aiComponent;

		private StateMachine stateMachine;

		private AwakeState awakeState;

		private PrepareState prepareState;

		private ExcuteState excuteState;

		private ExitState exitState;

		public bool isInterupt;

		private int time;

		private List<AbsAIBuff> buffList;

		private List<AbsTrigger> triggerList;

		private List<AbsCondition> awakeConditions;

		protected List<AbsCondition> exitConditions;

		private TweenMaterialFloat floatTween;

		private Color cacheColor;

		private float cacheValue;

		private bool isInitMaterial;

		private SkinnedMeshRenderer skinnedMeshRenderer;

		private ActionWarningEffectController actionWarningEffectController;

		private Action onAwake;

		private Entity currentTarget;

		public bool Enable => false;

		public AbsAction(NewMonsterAIComponent aiComponent, ActionConfig config)
		{
		}

		private void AddListener()
		{
		}

		public void ListenOnAwake(Action action)
		{
		}

		protected virtual void MapValue(ActionConfig config)
		{
		}

		private void GenerateBuff()
		{
		}

		private void GenerateTrigger()
		{
		}

		private void GenerateAwakeCondition()
		{
		}

		private void GenerateExitCondition()
		{
		}

		private void SetupStateMachine()
		{
		}

		public void SetAwakeState(bool cancelAnimation)
		{
		}

		public void SetPrepareState()
		{
		}

		public void SetExcuteState()
		{
		}

		public void SetExitState()
		{
		}

		public void SetInteruptState()
		{
		}

		public void Process(float deltaTime)
		{
		}

		public void OnChangeToExit()
		{
		}

		public void TakenDamage(float damage)
		{
		}

		protected virtual void OnChangeToAwake(bool cancelAnimation)
		{
		}

		protected virtual void OnChangeToPrepare()
		{
		}

		protected virtual bool IsEnable()
		{
			return false;
		}

		public void RemoveAllTriggers()
		{
		}

		public List<AbsTrigger> GetListTriggers()
		{
			return null;
		}

		protected abstract void OnExcute();

		protected abstract void OnExcute(float deltaTime);

		protected virtual void OnProcess(float deltaTime)
		{
		}

		protected virtual void OnExit()
		{
		}

		protected virtual void OnTakenDamage(float damage)
		{
		}

		public virtual void OnPrepare(float deltaTime)
		{
		}

		public ActionName GetConfigName()
		{
			return default(ActionName);
		}

		public ActionState GetCurrentState()
		{
			return null;
		}

		public ActionConfig GetConfig()
		{
			return null;
		}

		public Entity GetCurrentTarget(bool isForceUpdate = false)
		{
			return null;
		}

		public Bag<Entity> GetTargetList()
		{
			return null;
		}

		public bool CheckExit()
		{
			return false;
		}

		protected virtual bool IsExit()
		{
			return false;
		}

		public virtual bool AwakeCondition()
		{
			return false;
		}

		private bool IsInSkillState()
		{
			return false;
		}

		protected virtual bool IsInterupt()
		{
			return false;
		}

		public float GetTimeToFinishRecovery()
		{
			return 0f;
		}

		public bool IsFinishLocalCooldown()
		{
			return false;
		}

		public List<AbsCondition> GetAwakeConditions()
		{
			return null;
		}

		public void ReducePreparetime(float value)
		{
		}

		public void ReducePoint(float value)
		{
		}

		private void ResetTrigger()
		{
		}

		public void ResetPoint()
		{
		}

		private void ResetStartupTime()
		{
		}

		public void IncreaseLocalCooldown(float value)
		{
		}

		public void SetNewTimeToFinishLocalCooldown()
		{
		}

		public void SetNewTimeToFinishLocalCooldown(float newCooldown)
		{
		}

		public void SetNewTimeToFinishCooldown()
		{
		}

		private void ResetDamageTaken()
		{
		}

		protected ICallBack GetInput()
		{
			return null;
		}

		protected virtual float GetEffectOffsetDistance()
		{
			return 0f;
		}

		public virtual bool IsRequireTarget()
		{
			return false;
		}

		private void InitTweenMaterial()
		{
		}

		private void PlayMaterialEffect()
		{
		}

		private void StopMaterialEffect()
		{
		}

		private bool IsEnableTweenMaterialColor()
		{
			return false;
		}

		private bool IsEnableTweenValue()
		{
			return false;
		}

		private void BeDealDamage(int entityId, float damage)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private ActionName GetActionName()
		{
			return default(ActionName);
		}

		private void ActiveBuff(ActionStateExcuteBuff state)
		{
		}

		private void CheckBuffExitWithAction()
		{
		}

		private string GetAITag()
		{
			return null;
		}
	}
}
