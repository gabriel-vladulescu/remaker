using System;
using Artemis;
using Assets.Scripts.Ssar.Dungeon.Model;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.Dungeon.Signal
{
	public class SpawnMonsterSignal : Signal<MobSpawnInfo, Action<Entity>>
	{
	}
}
