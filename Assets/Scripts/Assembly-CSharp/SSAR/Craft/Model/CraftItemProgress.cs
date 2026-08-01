using System;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

namespace Ssar.Craft.Model
{
	[Serializable]
	public class CraftItemProgress
	{
		[JsonInclude]
		private ObscuredInt recipeId;

		[JsonInclude]
		private ObscuredInt visualId;

		[JsonInclude]
		private ObscuredInt startTime;

		public CraftItemProgress()
		{
		}

		public CraftItemProgress(int recipeId, int visualId, int startTime)
		{
		}

		public int GetRecipeId()
		{
			return 0;
		}

		public int GetVisualId()
		{
			return 0;
		}

		public int GetStartTime()
		{
			return 0;
		}
	}
}
