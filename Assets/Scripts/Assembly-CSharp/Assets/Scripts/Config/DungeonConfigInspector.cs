using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Config
{
	public class DungeonConfigInspector : MonoBehaviour
	{
		public int dungeonId;

		public GameObject heroPosition;

		public StageInspector[] stages;

		public List<GateInspector> gates;

		public List<StageActivatorInspector> stageActivators;

		public bool groupStageSpawnerByWave;

		private int waveToSwap1;

		private int waveToSwap2;

		public void Update()
		{
		}

		public void FetchDataFromChildrenGameObjects()
		{
		}

		private bool IsTriggerActivated(Transform trigger)
		{
			return false;
		}

		private void AddWaveNameChangeDetector(List<Transform> transforms)
		{
		}

		public void SwapWave(int wave1, int wave2, int stage)
		{
		}

		public Dictionary<int, List<Transform>> FindUngroupedTriggerByWave(Transform stage)
		{
			return null;
		}

		public Dictionary<int, List<Transform>> FindGroupedTriggerByWave(Transform stage)
		{
			return null;
		}

		public void CreateWaveTransforms(Transform stage, Dictionary<int, List<Transform>> triggerByWave)
		{
		}

		public StageInspector FindStageInspectorByIndex(int stageIndex)
		{
			return null;
		}

		public GateInspector FindGateInspectorById(int gateId)
		{
			return null;
		}

		public StageActivatorInspector FindStageActivatorInspectorById(int stageActivatorId)
		{
			return null;
		}

		public IEnumerable<int> GateIdList()
		{
			return null;
		}

		public IEnumerable<int> StageActivatorIdList()
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}

		public void OnWaveChanged(int currentWave, int newWave)
		{
		}

		private void SortWaveTransforms()
		{
		}
	}
}
