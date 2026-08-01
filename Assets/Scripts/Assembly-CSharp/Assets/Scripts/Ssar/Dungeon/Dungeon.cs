using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.Gates;
using Assets.Scripts.Ssar.Dungeon.StageActivators;
using Assets.Scripts.Ssar.Dungeon.Stages;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon
{
	public class Dungeon
	{
		public delegate void StageCycleDelegate(int stageOrder, StageCycle cycle);

		public delegate void GateCycleDelegate(int gateOrder, GateCycle cycle);

		public delegate void DungeonEventDelegate(DungeonEvent dungeonEvent);

		public delegate void StageWaveCycleDelegate(int stageOrder, int waveOrder, DefaultStage.WaveCycle cycle);

		public enum StageCycle
		{
			Start = 0,
			Clear = 1,
			End = 2
		}

		public enum GateCycle
		{
			Opened = 0,
			Closed = 1
		}

		public enum DungeonEvent
		{
			Restart = 0
		}

		private bool isStart;

		private List<Component> components;

		private List<DefaultStage> stages;

		private DefaultStage activeStage;

		private StageComponent activeStageComponent;

		private DungeonResult dungeonResult;

		private List<Gate> gates;

		private Gate activeGate;

		private GateComponent activeGateComponent;

		private List<StageActivator> stageActivators;

		private StageActivator activeStageActivator;

		private StageActivatorComponent activeStageActivatorComponent;

		private NotNullReference notNullReference;

		private int completedStagesCount;

		private bool isGateOpenedLastTimeCheck;

		private int currentStageOrder;

		private event StageCycleDelegate stageCycleEvent;

		private event GateCycleDelegate gateCycleEvent;

		private event DungeonEventDelegate dungeonEventDelegateEvent;

		private event StageWaveCycleDelegate stageWaveCycleEvent;

		public DungeonResult Result()
		{
			return default(DungeonResult);
		}

		public void StartUp()
		{
		}

		public void ShutDown()
		{
		}

		public void Update(float frameTimeInSeconds)
		{
		}

		public void Start()
		{
		}

		public void Restart()
		{
		}

		public void Stop()
		{
		}

		public void AddComponent(Component component)
		{
		}

		public void AddStage(DefaultStage stage)
		{
		}

		public void ResetResult()
		{
		}

		public void AddGate(Gate gate)
		{
		}

		public void AddStageActivator(StageActivator stageActivator)
		{
		}

		public int CompletedStagesCount()
		{
			return 0;
		}

		public void ListenToStageCycle(StageCycleDelegate listener)
		{
		}

		public void UnlistenToStageCycle(StageCycleDelegate listener)
		{
		}

		public void ListenToGateCycle(GateCycleDelegate listener)
		{
		}

		public void UnlistenToGateCycle(GateCycleDelegate listener)
		{
		}

		public void ListenToDungeonEvent(DungeonEventDelegate listener)
		{
		}

		public void UnlistenToDungeonEvent(DungeonEventDelegate listener)
		{
		}

		public void ListenToStageWaveCycle(StageWaveCycleDelegate listener)
		{
		}

		public void UnlistenToStageWaveCycle(StageWaveCycleDelegate listener)
		{
		}

		private void NotifyStageWaveCycle(int stageOrder, int waveOrder, DefaultStage.WaveCycle cycle)
		{
		}

		private void OnWaveCycle(int waveorder, DefaultStage.WaveCycle wavecycle)
		{
		}

		private void NotifyDungeonEvent(DungeonEvent dungeonEvent)
		{
		}

		private void NotifyGateCycle(int gateOrder, GateCycle cycle)
		{
		}

		private void NotifyStageCycle(int stageOrder, StageCycle cycle)
		{
		}

		private void UpdateComponents(float frameTimeInSeconds)
		{
		}

		private void CheckStagesIsConfigProperly()
		{
		}

		private void CheckStageCountMatchStageActivatorCount()
		{
		}

		private void CheckStageCountMatchGateCount()
		{
		}

		private void EvaluateDungeonResult()
		{
		}

		private void WaitForStageActivatorToActiveThenMoveToNextStage()
		{
		}

		private void WaitForGateFullyOpenThenActiveStageActivator()
		{
		}

		private void OpenGate()
		{
		}

		private bool IsStageTransitionTakingPlace()
		{
			return false;
		}

		private void MoveToNextStage()
		{
		}

		private bool IsLastStage()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
