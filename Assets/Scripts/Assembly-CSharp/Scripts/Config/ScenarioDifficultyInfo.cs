namespace Scripts.Config
{
	public class ScenarioDifficultyInfo
	{
		public string difficulty { get; set; }

		public int requireStar { get; set; }

		public bool enable { get; set; }

		public ScenarioDifficulty GetDifficulty()
		{
			return default(ScenarioDifficulty);
		}
	}
}
