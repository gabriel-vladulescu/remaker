using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class AddRewardFromArenaPromotionReward : Command
	{
		[Inject]
		public int RankID { get; set; }

		[Inject]
		public OnClaimPromotionArenaRankRewardSuccessSignal OnClaimPromotionArenaRankRewardSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private int Comparer(ItemInfo a, ItemInfo b)
		{
			return 0;
		}

		private int GetPriority(ItemType type)
		{
			return 0;
		}
	}
}
