public class DamageCalculateResult
{
	public float damage { get; set; }

	public bool isCrit { get; set; }

	public bool isImmune { get; set; }

	public bool isHealer { get; set; }

	public bool isDodge { get; set; }

	public bool isBlock { get; set; }

	public bool isMiss { get; set; }

	public bool isCcImmune { get; set; }

	public bool IsDamageDealtSuccessfully()
	{
		return false;
	}
}
