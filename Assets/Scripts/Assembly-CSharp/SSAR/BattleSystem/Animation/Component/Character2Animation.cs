using System.Collections.Generic;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.System.Animation.Component;
using UnityEngine;

namespace Ssar.BattleSystem.Animation.Component
{
	public class Character2Animation : CharacterAnimation
	{
		private readonly UnityEngine.Animation animation;

		public Character2Animation(UnityEngine.Animation animation, Transform transform, RoutineRunner routineRunner, Dictionary<string, float> scaleTimeByAnimationName)
			: base(null, null, null, null)
		{
		}

		public override void PlaySkill1()
		{
		}
	}
}
