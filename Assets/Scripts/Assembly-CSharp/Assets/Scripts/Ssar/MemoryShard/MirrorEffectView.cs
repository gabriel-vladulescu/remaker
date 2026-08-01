using UnityEngine;

namespace Assets.Scripts.Ssar.MemoryShard
{
	public class MirrorEffectView : MonoBehaviour
	{
		private class Character1MirrorConfig : AbsCharacterMirrorConfig
		{
			public Character1MirrorConfig(GameObject[] iconQuestion)
				: base(iconQuestion)
			{
			}

			protected override MirrorConfig Mirror1001()
			{
				return null;
			}
		}

		private class Character3MirrorConfig : AbsCharacterMirrorConfig
		{
			public Character3MirrorConfig(GameObject[] iconQuestion)
				: base(iconQuestion)
			{
			}

			protected override MirrorConfig Mirror1001()
			{
				return null;
			}
		}

		private class Character2MirrorConfig : AbsCharacterMirrorConfig
		{
			public Character2MirrorConfig(GameObject[] iconQuestion)
				: base(iconQuestion)
			{
			}

			protected override MirrorConfig Mirror1001()
			{
				return null;
			}
		}

		private abstract class AbsCharacterMirrorConfig
		{
			protected readonly GameObject[] iconQuestion;

			public AbsCharacterMirrorConfig(GameObject[] iconQuestion)
			{
			}

			protected abstract MirrorConfig Mirror1001();

			public MirrorConfig GetMirrorConfig(int mirrorId)
			{
				return null;
			}
		}

		private class MirrorConfig
		{
			private ShardPosition shard1;

			private ShardPosition shard2;

			private ShardPosition shard3;

			private ShardPosition shard4;

			public MirrorConfig(ShardPosition shard1, ShardPosition shard2, ShardPosition shard3, ShardPosition shard4)
			{
			}

			public ShardPosition GetShardPosition(int shard)
			{
				return null;
			}
		}

		private class ShardPosition
		{
			private Vector2 positionInUI2D;

			private readonly GameObject _iconQuestion;

			private readonly Vector3 _effectPosition;

			public ShardPosition(Vector2 positionInUI2d, GameObject iconQuestion, Vector3 effectPosition)
			{
			}

			public Vector2 Get2dUIPosition()
			{
				return default(Vector2);
			}

			public GameObject GetIconQuestion()
			{
				return null;
			}

			public Vector3 GetEffectPosition()
			{
				return default(Vector3);
			}
		}

		public GameObject[] fxShard;

		public UITexture[] shard;

		public GameObject fxShardFull;

		public GameObject[] iconQuestion;

		public void UpdateTexture(int groupId, int subId, int mirrorId)
		{
		}

		private void UpdateIconPosition(MirrorConfig mirrorConfig)
		{
		}

		private void UpdateUiPosition(MirrorConfig mirrorConfig)
		{
		}

		private AbsCharacterMirrorConfig GetCharacterMirrorConfig(int groupId, int subId)
		{
			return null;
		}
	}
}
