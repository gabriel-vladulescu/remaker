using System;
using Artemis.Interface;
using Assets.Scripts.Ssar.Combat.Effects;
using SSAR.BattleSystem.CharacterStatus;
using Ssar.BattleSystem.EntityTemplate;
using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class CharacterMediatorComponent : IComponent
	{
		public Action<CollisionFlags> OnCollision;

		private GameObject _prefab;

		private string layerMask;

		private SuperCharacterController characterController;

		private Vector3 colliderOriginalCenter;

		private Vector3 colliderOriginalSize;

		private GameObject original;

		private Vector3 additionalRotation;

		public Vector3 originalPos;

		private DirectionConfigData directionConfigData;

		private CharacterDeathConfigData deathConfigData;

		private BehitVfxConfigData behitVfxConfigData;

		private SoundEffectFollowCharacterState soundEffectFollowCharacterState;

		public Direction Direction { get; protected set; }

		public CharacterDeathConfigData DeathConfigData => null;

		public BehitVfxConfigData BehitVfxConfigData => null;

		public SoundEffectFollowCharacterState SoundEffectFollowCharacterState => null;

		public Vector3 Position
		{
			get
			{
				return _prefab != null ? _prefab.transform.position : originalPos;
			}
			set
			{
				if (_prefab != null)
				{
					_prefab.transform.position = value;
				}
			}
		}

		public bool IsGrounded => _prefab != null && Physics.Raycast(_prefab.transform.position + Vector3.up * 0.1f, Vector3.down, 0.15f);

		public bool IsCeiling => false;

		public Vector3 ColliderOriginalCenter => colliderOriginalCenter;

		public Vector3 ColliderOriginalSize => colliderOriginalSize;

		public CharacterMediatorComponent(Vector3 pos, GameObject gameObject, string layerMask = "NormalEntity")
		{
			InitValues(pos, gameObject, layerMask);
		}

		private void InitValues(Vector3 pos, GameObject gameObject, string layerMask)
		{
			originalPos = pos;
			original = gameObject;
			_prefab = gameObject;
			this.layerMask = layerMask;
			Direction = SSAR.BattleSystem.Movement.Direction.Right;

			if (_prefab != null)
			{
				_prefab.transform.position = pos;
				InitColliderAndPosition(pos);
			}
		}

		public void SwitchToGameObject(GameObject go, Vector3 rotation)
		{
			_prefab = go;
			if (_prefab != null)
			{
				_prefab.transform.eulerAngles = rotation;
			}
		}

		public void UpdateDirection(Direction value)
		{
			Direction = value;
			if (_prefab != null)
			{
				Vector3 euler = _prefab.transform.eulerAngles;
				euler.y = value == SSAR.BattleSystem.Movement.Direction.Right ? 0f : 180f;
				_prefab.transform.eulerAngles = euler;
			}
		}

		public void Move(Vector3 delta)
		{
			if (_prefab != null)
			{
				_prefab.transform.position += delta;
			}
		}

		public void MoveTo(Vector3 position)
		{
			Position = position;
		}

		public GameObject GetGameObject()
		{
			return _prefab;
		}

		public void UpdateModel(GameObject newModel)
		{
			_prefab = newModel;
		}

		public void DestroyGameObject()
		{
			if (_prefab != null)
			{
				UnityEngine.Object.Destroy(_prefab);
			}
		}

		private void InitColliderAndPosition(Vector3 pos)
		{
			Collider collider = _prefab != null ? _prefab.GetComponent<Collider>() : null;
			if (collider is CapsuleCollider capsule)
			{
				colliderOriginalCenter = capsule.center;
				colliderOriginalSize = new Vector3(capsule.radius, capsule.height, capsule.radius);
			}
		}

		public void SetLayerMask(string layerMask)
		{
			this.layerMask = layerMask;
		}
	}
}
