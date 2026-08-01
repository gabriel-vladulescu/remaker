using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using Ssar.Event.EventWar.Model;

namespace Ssar.Event.DemonInvasion.Model
{
	public class DemonInvasionTokenData
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
