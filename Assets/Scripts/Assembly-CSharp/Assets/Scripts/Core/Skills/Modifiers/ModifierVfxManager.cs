using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Utils;
using SSAR.BattleSystem.Effect;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ModifierVfxManager
	{
		private readonly CachingComponent cachingComponent;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly int groupId;

		private readonly int subId;

		private float elapsed;

		private List<EffectEditorInfo> vfxsToPlay;

		private List<GameObject> vfxs;

		private FrameAndSecondsConverter fasc;

		private List<EffectEditorInfo> playeds;

		private Dictionary<EffectEditorInfo, Transform> bones;

		private Character character;

		public ModifierVfxManager(Entity target)
		{
		}

		public void FollowCharacterFacingDirection(Character character)
		{
		}

		public void AddVfx(EffectPathIndex epi)
		{
		}

		public void Update(float dt)
		{
		}

		public void End()
		{
		}

		private bool PlayVfx(EffectEditorInfo effectEditorInfo, ref GameObject vfxRef)
		{
			return false;
		}

		private Vector3 GetPos(StatusEffectLayer posOnBody)
		{
			return default(Vector3);
		}

		private Transform GetBones(EffectEditorInfo effectEditorInfo)
		{
			return null;
		}

		private void ReturnVfxToPool(int index)
		{
		}
	}
}
