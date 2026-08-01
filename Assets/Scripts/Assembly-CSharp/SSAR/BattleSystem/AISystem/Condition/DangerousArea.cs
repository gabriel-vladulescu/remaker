using System;
using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.AI;
using UnityEngine;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class DangerousArea
	{
		private class DangerousAreaInfo
		{
			public Vector2 Position;

			public Vector2 Size;

			public float duration;

			private float t;

			public DangerousAreaInfo(Vector2 position, Vector2 size, float duration)
			{
			}

			public void Update(float deltaTime)
			{
			}

			public bool IsFinish()
			{
				return false;
			}
		}

		private readonly AbsAction absAction;

		private readonly NewMonsterAIComponent newMonsterAiComponent;

		private List<DangerousAreaInfo> skillHitBoxInfos;

		private Action newDangerousArea;

		private Action noDangeousArea;

		public DangerousArea(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent)
		{
		}

		public void ListenOnHasNewDanagerousArea(Action action)
		{
		}

		public void ListenOnFinishAllDangerousArea(Action action)
		{
		}

		public void Update(float deltaTime)
		{
		}

		public bool HasDangerousAreaBefore()
		{
			return false;
		}

		public bool IsInDangerousArea()
		{
			return false;
		}

		private DangerousAreaInfo GetSkillHitBoxInfo(string skillId, Entity entity)
		{
			return null;
		}
	}
}
