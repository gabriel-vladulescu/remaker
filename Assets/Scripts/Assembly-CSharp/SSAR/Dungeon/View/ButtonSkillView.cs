using System;
using Artemis;
using Assets.Scripts.Core.Skills.Cooldowns;
using Assets.Scripts.Ssar.Dungeon.View;
using SSAR.BattleSystem.Message;
using Scripts.Config;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class ButtonSkillView : strange.extensions.mediation.impl.View
	{
		public UISprite sp_bg;

		public UILabel lb_cooldown;

		public UILabel lb_level;

		public GameObject wg_lock;

		public GameObject wg_cooldown;

		public Action OnClick;

		public Action<bool> OnPress;

		public SkillChargeView SkillChargeView;

		public GameObject widgetSilent;

		protected Entity main;

		protected bool isLock;

		protected string skillId;

		private float cooldown;

		private GameObject fx;

		private int slot;

		private DungeonObserverManager dungeonObserverManager;

		private ParticleSystem[] particleSystems;

		public ISkillStat characterActiveSkillStat;

		private float cooldownForTextDisplay;

		private ISkillStat cached;

		private bool isSilent;

		private Assets.Scripts.Core.Skills.Cooldowns.Cooldown _cooldown;

		private UIButtonScale uiButtonScale;

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void SetSlot(int slot)
		{
		}

		public void Init(ISkillStat characterActiveSkillStat, string skillId)
		{
		}

		public void ModifyCharacterActiveSkillStat(ISkillStat characterActiveSkillStat)
		{
		}

		public void RevertCharacterActiveSkillStat()
		{
		}

		public virtual void OnSpawnCharacter(Entity main)
		{
		}

		public void Lock(ISkillStat characterActiveSkillStat)
		{
		}

		public virtual void Lock()
		{
		}

		private void Click(GameObject go, bool pressed)
		{
		}

		private void Press(GameObject go, bool pressed)
		{
		}

		private void InitFx()
		{
		}

		protected virtual void Update()
		{
		}

		public void PlayFx()
		{
		}

		private void UpdateCooldownTextDisplay(float cd)
		{
		}

		protected virtual void ObserverOnCastSkill(int entityId, string skillId)
		{
		}

		protected virtual float GetCooldown()
		{
			return 0f;
		}

		private int GetCharge()
		{
			return 0;
		}

		private Assets.Scripts.Core.Skills.Cooldowns.Cooldown GetCooldownData()
		{
			return null;
		}

		private bool IsSkillEnabled()
		{
			return false;
		}

		private void ToggleButtonScale(bool enable)
		{
		}
	}
}
