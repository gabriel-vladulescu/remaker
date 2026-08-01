using SSAR.Equipment.Enum;

public interface ICollectData
{
	int collectID { get; set; }

	CollectType collectType { get; set; }
}
