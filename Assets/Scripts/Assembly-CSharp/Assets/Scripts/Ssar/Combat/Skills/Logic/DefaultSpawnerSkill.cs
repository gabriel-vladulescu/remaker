using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultSpawnerSkill : Skill
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			public float spawnY;

			public EventFrame ef;

			public float destinationX;

			public float spawnX;

			public DefaultSpawnerSkill _003C_003E4__this;

			internal void _003CWaitThenSpawn_003Eb__0(GameObject o, int i)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitThenSpawn_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float spawnY;

			public EventFrame ef;

			public float destinationX;

			public float spawnX;

			public DefaultSpawnerSkill _003C_003E4__this;

			private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitThenSpawn_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitThenSuicide_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public GameObject o;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitThenSuicide_003Ed__19(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private readonly Dependencies dependencies;

		protected readonly Assets.Scripts.Core.Skills.Environment environment;

		protected Dictionary<EventFrame, float> spawnTimeByEventFrame;

		protected Dictionary<EventFrame, int> spawnCountByEventFrame;

		public DefaultSpawnerSkill(Dependencies dependencies)
			: base(null, null, null, null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override void PlayVfx(EventFrame ef)
		{
		}

		protected virtual void OnVfxPlayed(EventFrame ef, GameObject obj)
		{
		}

		public override List<Projectile> LaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		public override void SpawnMonster(EventFrame ef)
		{
		}

		public override float[] InputIgnoreWindow()
		{
			return null;
		}

		protected virtual void UpdateSpawn(float dt)
		{
		}

		protected void Spawn(EventFrame ef)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenSpawn_003Ed__17))]
		private IEnumerator WaitThenSpawn(EventFrame ef, float spawnX, float spawnY, float destinationX)
		{
			return null;
		}

		protected virtual void OnSpawn(EventFrame ef, GameObject obj)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenSuicide_003Ed__19))]
		private IEnumerator WaitThenSuicide(float waitTime, GameObject o)
		{
			return null;
		}

		private static void JumpToDestination(EventFrame ef, GameObject o, float destinationX, float spawnX)
		{
		}

		private float Random(float spawnX, float xAxisAmplitude, int xAxisDensity)
		{
			return 0f;
		}
	}
}
