namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryQuestConstant
	{
		public string questType;

		public double questRequireConstantX;

		public double questRequireConstantA;

		public double questRewardConstantX;

		public double questRewardConstantA;

		public double questRewardConstantB;

		public bool rewardRandomById { get; set; }

		public bool requireRandomById { get; set; }

		public QuestType GetQuestType()
		{
			return default(QuestType);
		}
	}
}
