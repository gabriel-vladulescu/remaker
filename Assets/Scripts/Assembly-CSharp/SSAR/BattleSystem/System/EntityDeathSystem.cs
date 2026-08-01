using System.Collections.Generic;
using Artemis;
using Artemis.System;
using UnityEngine;

namespace SSAR.BattleSystem.System
{
	public class EntityDeathSystem : EntityProcessingSystemWithTime
	{
		private List<GameObject> corpses;

		private bool isClearAllCoprse;

		public EntityDeathSystem(bool subscribeSimTime)
			: base(null, subscribeSimTime: false)
		{
		}

		protected override void Process(Entity entity, float deltaTime)
		{
		}

		public override void Process()
		{
		}

		public void ClearAllCorpse()
		{
		}
	}
}
