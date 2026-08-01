namespace Assets.Scripts.Ssar.MemoryShard
{
	public class MemoryShardSignalManager
	{
		[Inject]
		public ShowMemoryShardPopupSignal ShowMemoryShardPopupSignal { get; set; }

		[Inject]
		public ShowViewMemoryShardStoryPopupSignal ShowViewMemoryShardStoryPopupSignal { get; set; }

		[Inject]
		public ShowCollectNewShardPOpupSignal ShowCollectNewShardPOpupSignal { get; set; }
	}
}
