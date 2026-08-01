using System;
using UnityEngine;

namespace Assets.Scripts.Config
{
	[Serializable]
	public class StageActivatorInspector
	{
		[HideInInspector]
		public int stageActivatorId;

		public StageActivatorName stageActivatorName;

		public GameObject location;
	}
}
