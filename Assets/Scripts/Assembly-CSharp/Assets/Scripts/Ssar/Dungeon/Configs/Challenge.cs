namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface Challenge
	{
		int WaveOrder();

		Trigger StartTrigger();

		Trigger MainTrigger();
	}
}
