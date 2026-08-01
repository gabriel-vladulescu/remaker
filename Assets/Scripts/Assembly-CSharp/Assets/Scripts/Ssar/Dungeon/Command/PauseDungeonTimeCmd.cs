using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Common.Pooling;
using Assets.Scripts.Ssar.Common.System.GameLoop;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.System;
using UnityEngine;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class PauseDungeonTimeCmd : strange.extensions.command.impl.Command
	{
		private class Cache
		{
			private List<ParticleSystem> particleSystems;

			private List<AnimatorAndSpeed> animators;

			private List<AnimationAndSpeed> animations;

			private Action<GameObjectItem> obtainedItemCallback;

			private bool isPause;

			public List<ParticleSystem> ParticleSystems => null;

			public List<AnimatorAndSpeed> Animators => null;

			public List<AnimationAndSpeed> Animations => null;

			public Action<GameObjectItem> ObtainedItemCallback => null;

			public bool IsPause
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public void AddParticleSystems(ParticleSystem[] ps)
			{
			}

			public void AddAnimators(AnimatorAndSpeed[] a)
			{
			}

			public void AddAnimations(AnimationAndSpeed[] a)
			{
			}

			public void Clear()
			{
			}

			public void AddObtainedItemCallback(Action<GameObjectItem> obtainedItemCallback)
			{
			}
		}

		private class AnimationAndSpeed
		{
			private Animation animation;

			private string animationName;

			private float speed;

			public Animation Animation => null;

			public string AnimationName => null;

			public float Speed => 0f;

			public AnimationAndSpeed(Animation animation, string animationName, float speed)
			{
			}
		}

		private class AnimatorAndSpeed
		{
			private Animator animator;

			private float speed;

			public Animator Animator => null;

			public float Speed => 0f;

			public AnimatorAndSpeed(Animator animator, float speed)
			{
			}
		}

		[Inject]
		public bool isPause { get; set; }

		[Inject]
		public DungeonFrameTimeSubcribe DungeonFrameTimeSubcribe { get; set; }

		[Inject]
		public RoutineRunner routineRunner { get; set; }

		[Inject]
		public GameLoop gameLoop { get; set; }

		public override void Execute()
		{
		}

		private void ResumeAnimationAndFx(Cache cache)
		{
		}

		private void PauseAnimationAndFx(Cache cache)
		{
		}

		private Action<GameObjectItem> Callback(Cache cache)
		{
			return null;
		}

		private void PauseAnimationAndFx(Cache cache, GameObject go)
		{
		}
	}
}
