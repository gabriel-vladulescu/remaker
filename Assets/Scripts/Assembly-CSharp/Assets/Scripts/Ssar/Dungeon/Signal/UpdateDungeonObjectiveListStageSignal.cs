using System.Collections.Generic;
using SSAR.Dungeon.Model;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.Dungeon.Signal
{
	public class UpdateDungeonObjectiveListStageSignal : Signal<List<DungeonObjectiveManager.StageGoal>>
	{
	}
}
