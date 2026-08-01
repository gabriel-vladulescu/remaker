public static class DamageUtils
{
	public const float DAMAGE_RANDOM_RANGE = 0.02f;

	public const float MAGIC_RES_CONSTANT = 200f;

	public const float MAX_DAMAGE_REDUCTION = 1f;

	public const float MAX_DAMAGE_REDUCTION_FROM_DEF = 0.75f;

	public const float DEF_HP_RATIO = 0.1f;

	public const float PHYSICAL_MIN_DAMAGE = 0f;

	public static DamageCalculateResult GetFinalDamage(DamageData damageData)
	{
		return null;
	}

	public static float GetRandomRawDamage(DamageData damageData)
	{
		return 0f;
	}

	public static float GetDamageBonusMultiple(DamageData damageData)
	{
		return 0f;
	}

	public static float GetRandomDamageAfterBlockAndReduce(DamageData damageData, out bool isBlock)
	{
		isBlock = default(bool);
		return 0f;
	}

	public static float GetDamageAfterBlockAndReduceByAfmor(DamageData damageData, out bool isBlock)
	{
		isBlock = default(bool);
		return 0f;
	}

	public static int GetCritFlag(DamageData damageData)
	{
		return 0;
	}

	public static int GetDodgeFlag(DamageData damageData)
	{
		return 0;
	}

	public static int GetMissFlag(DamageData damageData)
	{
		return 0;
	}

	public static int GetImmuneFlag(DamageData damageData)
	{
		return 0;
	}

	public static float GetCritDamageMul(DamageData damageData)
	{
		return 0f;
	}

	public static float GetMinDamageByType(DamageData damageData)
	{
		return 0f;
	}

	public static float GetTargetDamageBlockByType(DamageData damageData, out bool isBlock)
	{
		isBlock = default(bool);
		return 0f;
	}

	public static float GetTargetDamageReductionByType(DamageData damageData)
	{
		return 0f;
	}

	private static bool EnableDebug()
	{
		return false;
	}
}
