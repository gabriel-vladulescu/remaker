using SSAR.BattleSystem.Damage;

namespace SSAR.Dungeon.HUD
{
	public class ChangeHpParameter
	{
		public float healthChangeAmount;

		public float curHp;

		public float maxHp;

		public bool isCritical;

		public HUDTextType elementCounter;

		public float beHitVfxOffsetOnXAxis;

		public DamageType DamageType;

		public bool isIgnoreDef;

		public bool isBlock;

		public bool isHealer;

		public bool isMiss;

		public bool displayText;

		public ChangeHpParameter(DamageType damageType, float damage, float curHP, float maxHP, bool critFlag, bool isHealer, bool isIgnoreDef, bool isBlock, bool isMiss, bool displayText = true, float beHitVfxOffsetOnXAxis = 0f)
		{
		}
	}
}
