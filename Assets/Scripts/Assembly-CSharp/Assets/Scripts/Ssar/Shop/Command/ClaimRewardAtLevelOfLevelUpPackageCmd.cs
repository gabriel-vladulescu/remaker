using Assets.Scripts.Ssar.Shop.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ClaimRewardAtLevelOfLevelUpPackageCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int level { get; set; }

		[Inject]
		public IShowLevelUpPackagePopupParameter Parameter { get; set; }

		public override void Execute()
		{
		}
	}
}
