using System;
using UnityEngine;

namespace Assets.Scripts.Config
{
	[Serializable]
	public class GateInspector
	{
		[HideInInspector]
		public int gateId;

		public GateName gateName;

		public GameObject location;
	}
}
