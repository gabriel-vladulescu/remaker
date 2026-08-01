using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.SceneLoader.View
{
	[Serializable]
	public class LoadingSceneCharacterConfig
	{
		public int groupId;

		public float relativePosY;

		public float absolutePosY;

		public float relativePosX;

		public float absolutePosX;

		public float scale;

		public Vector2 outlineSize;

		public Color32 outlineColor;

		public Color32 mainColor;

		public List<LoadingSceneCharacterAnimation> Animations;
	}
}
