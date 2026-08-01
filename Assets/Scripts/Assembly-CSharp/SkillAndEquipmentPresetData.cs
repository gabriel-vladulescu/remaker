using LitJson;

public class SkillAndEquipmentPresetData
{
	[JsonInclude]
	private SkillEquippedData skillEquippedData;

	[JsonInclude]
	private bool hasInited;

	public void Init()
	{
	}

	public SkillEquippedData GetSkillEquippedData()
	{
		return null;
	}

	public void TransferData(MainCharacterData mcd)
	{
	}

	public void TransferData(SkillAndEquipmentPresetData mcd)
	{
	}

	public bool HasInited()
	{
		return false;
	}
}
