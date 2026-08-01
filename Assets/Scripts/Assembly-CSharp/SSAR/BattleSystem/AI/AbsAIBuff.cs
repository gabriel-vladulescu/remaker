using Artemis;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public abstract class AbsAIBuff
	{
		protected Entity self;

		protected AIBuffConfig config;

		public float duration;

		public float value;

		private float time;

		private bool hasExcute;

		private bool isExitByAction;

		private GameObject effectObj;

		public AbsAIBuff(Entity self, AIBuffConfig config)
		{
		}

		public AIBuffType GetBuffType()
		{
			return default(AIBuffType);
		}

		public ActionStateExcuteBuff GetStateExcuteBuff()
		{
			return default(ActionStateExcuteBuff);
		}

		public bool HasExcute()
		{
			return false;
		}

		protected virtual void MapValue(AIBuffConfig config)
		{
		}

		public void Enter()
		{
		}

		public void Update(float deltaTime)
		{
		}

		public void Exit()
		{
		}

		public virtual bool IsExit()
		{
			return false;
		}

		protected bool IsPassive()
		{
			return false;
		}

		public void SetExitByAction()
		{
		}

		protected string GetName()
		{
			return null;
		}

		protected bool AddToStatusBar()
		{
			return false;
		}

		private void SpawnEffect()
		{
		}

		private void UpdateEffectPosition()
		{
		}

		private void RecycleEffect()
		{
		}

		protected abstract void OnEnter();

		protected abstract void OnUpdate(float deltaTime);

		protected abstract void OnExit();
	}
}
