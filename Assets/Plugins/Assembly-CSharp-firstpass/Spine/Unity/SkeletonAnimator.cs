using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Spine.Unity
{
	[RequireComponent(typeof(Animator))]
	public class SkeletonAnimator : SkeletonRenderer, ISkeletonAnimation
	{
		[Serializable]
		public class MecanimTranslator
		{
			public enum MixMode
			{
				AlwaysMix = 0,
				MixNext = 1,
				SpineStyle = 2
			}

			public bool autoReset;

			public MixMode[] layerMixModes;

			private readonly Dictionary<int, Animation> animationTable;

			private readonly Dictionary<AnimationClip, int> clipNameHashCodeTable;

			private readonly List<Animation> previousAnimations;

			private Animator animator;

			public Animator Animator => null;

			public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset)
			{
			}

			public void Apply(Skeleton skeleton)
			{
			}

			private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed)
			{
				return 0f;
			}

			private static float AnimationTime(float normalizedTime, float clipLength, bool reversed)
			{
				return 0f;
			}

			private int NameHashCode(AnimationClip clip)
			{
				return 0;
			}
		}

		[SerializeField]
		protected MecanimTranslator translator;

		public MecanimTranslator Translator => null;

		protected event UpdateBonesDelegate _UpdateLocal;

		protected event UpdateBonesDelegate _UpdateWorld;

		protected event UpdateBonesDelegate _UpdateComplete;

		public event UpdateBonesDelegate UpdateLocal
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateWorld
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		public override void Initialize(bool overwrite)
		{
		}

		public void Update()
		{
		}
	}
}
