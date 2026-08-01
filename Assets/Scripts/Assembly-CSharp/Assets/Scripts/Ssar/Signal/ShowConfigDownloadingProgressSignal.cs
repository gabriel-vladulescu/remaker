using Scripts.Config.Remote;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.Signal
{
	public class ShowConfigDownloadingProgressSignal : Signal<ConfigVersion, string, int>
	{
	}
}
