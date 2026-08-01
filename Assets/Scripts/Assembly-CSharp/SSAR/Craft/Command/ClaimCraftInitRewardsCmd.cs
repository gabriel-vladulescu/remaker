using Scripts.Config;
using strange.extensions.command.impl;

namespace Ssar.Craft.Command
{
	public class ClaimCraftInitRewardsCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CraftConfig.Feature Feature { get; set; }

		public override void Execute()
		{
		}
	}
}
