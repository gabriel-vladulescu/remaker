using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

namespace Ssar.Event.EventWar.Model
{
	public class WarTokenData
	{
		[JsonInclude]
		private ObscuredInt token;

		[JsonInclude]
		private TokenLogData tokenLogData;

		public int Token => 0;

		public void AddToken(int amount, RewardReason source)
		{
		}
	}
}
