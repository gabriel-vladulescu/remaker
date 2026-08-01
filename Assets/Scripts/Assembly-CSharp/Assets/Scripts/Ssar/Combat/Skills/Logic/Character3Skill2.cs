using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character3Skill2 : DefaultMeleeSkill
	{
		public class Character3Skill2Info
		{
			public GridsInfo gridsInfo;
		}

		public class GridsInfo
		{
			public Vector2 originOffset;

			public Vector2 size;

			public Vector2 columnRow;

			public int sphereCount;

			public bool randomPositionInsideCircle;

			public float circleRadius;

			public float deltaScaleFactorForSphere;

			public float delayRange;

			public float delayRangeLightning;

			public float lightningTimeToLive;
		}

		[CompilerGenerated]
		private sealed class _003CWaitThenInvoke_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public Action action;

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
			public _003CWaitThenInvoke_003Ed__17(int _003C_003E1__state)
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

		private Character3Skill2Info info;

		private SkillData skillData;

		private RoutineRunner routineRunner;

		private Dictionary<int, Vector2> cellsById;

		private int id;

		private bool isProjectileCreated;

		private List<GameObject> vfxPlayPriorToProjectile;

		private List<GameObject> deadLightnings;

		private Dictionary<GameObject, ParticleSystem[]> particleSystemsByVfxPlayPriorToProjectile;

		private Dictionary<GameObject, float> ballDelayByVfxPlayPriorToProjectile;

		public Character3Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile)
		{
		}

		protected override VfxToPlay[] ListAllVfxToPlay(EventFrame ef)
		{
			return null;
		}

		public override bool IsInterruptibleWhileChanneling()
		{
			return false;
		}

		private int FindIndexOfCell(Vector2 cell, Vector2[] cells)
		{
			return 0;
		}

		private GameObject FindVfxOfLength(float length, GameObject[] prefabs)
		{
			return null;
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenInvoke_003Ed__17))]
		private IEnumerator WaitThenInvoke(float waitTime, Action action)
		{
			return null;
		}

		private static Vector2 UnitLength(Vector2 size, Vector2 columnRow)
		{
			return default(Vector2);
		}

		public static void OnDrawGizmos(SkillEventFrameConfig sefc, SkillConfig sc)
		{
		}
	}
}
