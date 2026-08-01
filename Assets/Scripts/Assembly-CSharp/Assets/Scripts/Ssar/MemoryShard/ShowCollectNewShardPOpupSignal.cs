using System;
using Scripts.Config;
using UnityEngine;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.MemoryShard
{
	public class ShowCollectNewShardPOpupSignal : Signal<bool, Action<GameObject>, MemoryShardInfo, Action>
	{
	}
}
