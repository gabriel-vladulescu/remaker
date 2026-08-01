using Artemis;
using SSAR.BattleSystem.Input;

public class InputMappingDataManager
{
	private ActionType inputAttack;

	private ActionType inputDash;

	private ActionType[] inputCastSkill;

	private Entity main;

	public void SetMain(Entity entity)
	{
	}

	public ActionType GetInputAttack()
	{
		return default(ActionType);
	}

	public ActionType GetInputDash()
	{
		return default(ActionType);
	}

	public void SetInputAttack(Entity entity, ActionType actionType)
	{
	}

	public void SetInputDash(Entity entity, ActionType actionType)
	{
	}

	public ActionType GetInputSkill(int inputIndex)
	{
		return default(ActionType);
	}

	public void SetInputSkill(Entity entity, int inputIndex, ActionType actionType)
	{
	}
}
