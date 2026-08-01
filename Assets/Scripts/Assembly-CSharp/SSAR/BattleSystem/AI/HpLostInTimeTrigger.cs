using System;
using System.Collections.Generic;
using SSAR.BattleSystem.Damage;

namespace SSAR.BattleSystem.AI
{
	public class HpLostInTimeTrigger : AbsTrigger
	{
		private class Data
		{
			public float time;

			public float hpPercent;

			private Action trigger;

			public Data(float time, float hpPercent)
			{
			}
		}

		public float pointDeduct;

		public float hpLost;

		public float timeThreshold;

		private Dictionary<float, Data> dict;

		private float time;

		private bool flag;

		private float newDmgReceive;

		public HpLostInTimeTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		private void DamageCalculationSystemOnOnEntityBeDealDamage(int id, int casterId, float damage, DamageSource damageSource)
		{
		}

		public override bool IsTrigger()
		{
			return false;
		}

		public override void OnTrigger(float deltaTime, ref float point)
		{
		}
	}
}
