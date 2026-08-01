using SSAR.Cooldown.System;

namespace SSAR.Dungeon.View
{
	public class HpPotionView : ButtonSkillView
	{
		public static readonly int HP_POTION_ID;

		public UISprite sp_icon;

		public UISprite sp_icon_challenge;

		public UILabel lb_quantity;

		private float cooldown;

		private int quantity;

		private SkillCooldownManager skillCooldownManager;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		internal void OnUsePotion()
		{
		}

		private void UpdateData()
		{
		}

		protected override void ObserverOnCastSkill(int entityId, string skillId)
		{
		}

		protected override float GetCooldown()
		{
			return 0f;
		}

		public void Hide(bool hide)
		{
		}

		private bool IsMaxHp()
		{
			return false;
		}
	}
}
