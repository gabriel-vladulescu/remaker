namespace Scripts.Config
{
	public class ScenarioDifficultyInfo
	{
		public string difficulty { get; set; }

		public int requireStar { get; set; }

		public bool enable { get; set; }

		public ScenarioDifficulty GetDifficulty()
		{
			if (string.IsNullOrEmpty(difficulty) || !System.Enum.TryParse<ScenarioDifficulty>(difficulty, out var result))
			{
				return ScenarioDifficulty.NORMAL;
			}
			return result;
		}
	}
}
