namespace Assets.Scripts.Core.Skills.Modifiers
{
	public interface BuffFactory
	{
		bool Create(EventFrame ef, Character caster, Character target, ref Modifier modifier);
	}
}
