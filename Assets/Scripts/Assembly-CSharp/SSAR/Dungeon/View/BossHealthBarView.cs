using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class BossHealthBarView : strange.extensions.mediation.impl.View
	{
		public UISlider slider;

		public UILabel lb_name;

		public UITable Table;

		public UILabel lb_hpPercent;

		private Entity entity;

		private HealthComponent healthComponent;

		private List<ModifierStatusView> modifierStatusViews;

		private float time;

		private float DELAY_UPDATE;

		protected override void Awake()
		{
		}

		public void OnRegister()
		{
		}

		public void OnSpawnMonster(Entity entity)
		{
		}

		private void Update()
		{
		}

		private void TrackHp()
		{
		}

		private void TrackStatus()
		{
		}
	}
}
