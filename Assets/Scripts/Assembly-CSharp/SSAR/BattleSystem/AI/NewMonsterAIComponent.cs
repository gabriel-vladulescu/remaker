using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Artemis;
using Artemis.Interface;
using Artemis.Utils;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class NewMonsterAIComponent : IComponent
	{
		public delegate void OnMove(float time);

		public delegate void OnExitAction(AbsAction absAction);

		public delegate void OnExcuteAction(AbsAction absAction);

		public delegate void OnRunAction(AbsAction absAction);

		private class EntityScore
		{
			public int score;

			public Entity entity;

			public float distance;
		}

		public AbsAction currentAction;

		public Entity currentTarget;

		private Dictionary<string, List<AbsAction>> dic;

		private List<AbsAction> actions;

		private Dictionary<string, InteruptAction> interuptTransition;

		public Entity self;

		public string mobType;

		public List<AIFlag> flags;

		public List<int> skillEquipped;

		private bool enable;

		private NewAIDelayEnableConfig aiDelayEnableConfig;

		private NewAIAdvanceConfig newAiAdvanceConfig;

		private float timeUpdateTarget;

		private float timeToUpdateAction;

		private Dictionary<AIFlag, List<AbsAction>> actionDictWithFlag;

		private List<AIFlag> listFlagHasExcute;

		private GameObject stateEffect;

		private float lifeTime;

		private float timeToResetCooldown;

		private float lastUpdateTime;

		private float cooldownUseSkill;

		private float timeEnable;

		private readonly List<EntityScore> _scores;

		private readonly List<int> _listId;

		private readonly Bag<Entity> _cacheBag;

		public event OnMove On_Move;

		public event OnExcuteAction On_ExcuteAction;

		public event OnRunAction On_RunAction;

		public event OnExitAction On_ExitAction;

		public NewMonsterAIComponent(Entity self, List<ActionConfig> actionConfigs, NewAIDelayEnableConfig delayConfig, NewAIAdvanceConfig newAiAdvanceConfig, string mobTye, List<int> skillEquipped = null)
		{
		}

		public NewAIAdvanceConfig GetNewAiAdvanceConfig()
		{
			return null;
		}

		private void DamageCalculationSystemOnOnEntityDie(Entity entity)
		{
		}

		public void Moving(float deltaTIme)
		{
		}

		public void InvokeExit(AbsAction action)
		{
		}

		public void InvokeRunAction(AbsAction action)
		{
		}

		public void InvokeExcuteAction(AbsAction action)
		{
		}

		public void SetupAction(List<ActionConfig> actionConfigs)
		{
		}

		public void Remove()
		{
		}

		public AbsAction GetAction(int actionId)
		{
			return null;
		}

		public bool IsInterupt()
		{
			return false;
		}

		public void ChangeToInterupt()
		{
		}

		private int Comparer(AbsAction actionA, AbsAction actionB)
		{
			return 0;
		}

		public void AddFlag(AIFlag flag)
		{
		}

		public bool HasFlag(AIFlag flag)
		{
			return false;
		}

		public bool HasExcuteFlag(AIFlag flag)
		{
			return false;
		}

		public List<AbsAction> GetActions()
		{
			return null;
		}

		public List<AbsAction> GetActionsWithType(ActionName actionName)
		{
			return null;
		}

		public void SetEnable(bool enable)
		{
		}

		public bool Enable()
		{
			return false;
		}

		public void Update(float delta)
		{
		}

		public void UpdateByPassCondition(float deltaTime)
		{
		}

		public Entity GetDefaultTarget(bool bypassDelay = false)
		{
			return null;
		}

		public float GetLifeTime()
		{
			return 0f;
		}

		public bool EnableUpdateAction()
		{
			return false;
		}

		public void UpdateActionSuccess()
		{
		}

		public float GetLastUpdateTime()
		{
			return 0f;
		}

		public float GetDelayUpdateTarget()
		{
			return 0f;
		}

		public float GetDelayUpdateAction()
		{
			return 0f;
		}

		public void SetNewTimeToResetCooldown(float newTime)
		{
		}

		public float GetTimeToResetCooldown()
		{
			return 0f;
		}

		public bool IsFinishCooldown()
		{
			return false;
		}

		public void SetCooldownAllSkill(float cooldown)
		{
		}

		public bool IsFinishCooldownSkill()
		{
			return false;
		}

		public void ManualExitAction()
		{
		}

		private void LogTimeFinishRecovery()
		{
		}

		private void LogTimeFinishGlobalCooldown()
		{
		}

		private void SetupInterupt<TFrom, TTo>() where TFrom : AbsAction where TTo : InteruptAction
		{
		}

		private InteruptAction GetInteruptAction(Type type)
		{
			return null;
		}

		private void UpdateEffectPosition()
		{
		}

		private void SetupDictionaryActionWithFlag()
		{
		}

		private void AddAction(AbsAction action)
		{
		}

		public Entity GetTarget(List<TargetScore> group, List<TargetScore> tag, bool bypassDelay = false)
		{
			return null;
		}

		public Bag<Entity> GetTargetList()
		{
			return null;
		}

		public Bag<Entity> GetTargetList(List<TargetScore> group, List<TargetScore> tag)
		{
			return null;
		}

		private Bag<Entity> GetBag(List<EntityScore> scores)
		{
			return null;
		}

		private EntityScore GetEntityScore(Entity entity, List<TargetScore> scores, bool isGroup)
		{
			return null;
		}

		private int ComparerScore(EntityScore a, EntityScore b)
		{
			return 0;
		}
	}
}
