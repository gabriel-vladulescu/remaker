using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using Com.LuisPedroFonseca.ProCamera2D;
using SSAR.BattleSystem.Camera;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class EntityEnvironment : Assets.Scripts.Core.Skills.Environment
	{
		[CompilerGenerated]
		private sealed class _003CWaitThenResetTimeScale_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public float timeScale;

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
			public _003CWaitThenResetTimeScale_003Ed__34(int _003C_003E1__state)
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

		private EntityWorld entityWorld;

		private RoutineRunner routineRunner;

		private ResourcesLoader resourcesLoader;

		private EffectPool effectPool;

		private UserInput userInput;

		private Entity camera;

		private float original;

		private List<CameraTarget> cameraTargets;

		private GameObject cameraTarget;

		private float targetInfluenceV;

		public EntityEnvironment(EntityWorld entityWorld, RoutineRunner routineRunner, ResourcesLoader resourcesLoader, EffectPool effectPool, UserInput userInput)
		{
		}

		public List<Character> FindNearbyCharacters(Character subject, Vector3 relativePosition, float distance, params FindingFilter[] filter)
		{
			return null;
		}

		public List<Character> FindCharactersWithIn(Character subject, Vector3 center, Vector2 size, params FindingFilter[] filter)
		{
			return null;
		}

		private bool Filter(Character subject, Entity e, params FindingFilter[] filter)
		{
			return false;
		}

		public float MostLeftOfMap()
		{
			return 0f;
		}

		public float MostRightOfMap()
		{
			return 0f;
		}

		public float CeilOfMap()
		{
			return 0f;
		}

		public float GroundOfMap(float positionOnXAxis)
		{
			return 0f;
		}

		public void PlayCameraFx(Character caster, EventFrame ef)
		{
		}

		public void PlaySfx(EventFrame ef)
		{
		}

		public void FadeoutSfx(string path)
		{
		}

		public GameObject InstantiateGameObject(GameObject prefab)
		{
			return null;
		}

		public GameObject InstantiateGameObject(string prefabPath)
		{
			return null;
		}

		public GameObject InstantiateGameObject(string prefabPath, GameObject prefab)
		{
			return null;
		}

		public void RecycleVfx(GameObject vfx)
		{
		}

		public ResourcesLoader ResourcesLoader()
		{
			return null;
		}

		public Vector4 ViewPortBoundaryInWorldPosition()
		{
			return default(Vector4);
		}

		public void StopCameraFromTrackingTargets()
		{
		}

		public void StartCameraToTrackPosition(Vector2 position)
		{
		}

		public void StartCameraToTrackEntity(int entityId)
		{
		}

		public void CinematicControl(CinematicCameraControl control)
		{
		}

		public bool IsHoldingAttack()
		{
			return false;
		}

		public void StopCameraFromTrackingOnYAxis()
		{
		}

		public void StartCameraToTrackingOnYAxis()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenResetTimeScale_003Ed__34))]
		private IEnumerator WaitThenResetTimeScale(float waitTime, float timeScale)
		{
			return null;
		}
	}
}
