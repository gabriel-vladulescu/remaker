using System.Collections.Generic;
using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	[AddComponentMenu("NGUI/Examples/HUD Text")]
	[ExecuteInEditMode]
	public class HUDText : MonoBehaviour
	{
		protected class Entry
		{
			public float time;

			public float offset;

			public float val;

			public Vector3 startOffset;

			public UILabel label;

			public float movementStart => 0f;
		}

		protected class EntryParameters
		{
			public object obj;

			public HUDTextInfo hudInfo;

			public EntryParameters(object o, HUDTextInfo hud)
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		private UIFont font;

		public UIFont bitmapFont;

		public Font trueTypeFont;

		public int depth;

		public FontStyle fontStyle;

		public string textFormat;

		public float duration;

		public float delayBetweenEntry;

		public float maxOffsetValue;

		public AnimationCurve offsetCurve;

		public AnimationCurve alphaCurve;

		public float maxScaleValue;

		public AnimationCurve scaleCurve;

		public Vector3 maxRandomStartOffset;

		public Vector3 shiftOffset;

		private List<Entry> mList;

		private List<Entry> mUnused;

		private Queue<EntryParameters> queuedEntry;

		private float queueDelay;

		private int counter;

		private bool mUseDynamicFont;

		public bool isVisible => false;

		public Object ambigiousFont
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static int Comparison(Entry a, Entry b)
		{
			return 0;
		}

		private Entry Create()
		{
			return null;
		}

		private void Delete(Entry ent)
		{
		}

		public void Add(object obj, HUDTextInfo hudInfo)
		{
		}

		protected Entry AddEntry(object obj, HUDTextInfo hudInfo)
		{
			return null;
		}

		private void FixStartEntryOffset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void ProcessQueue()
		{
		}

		private void ProcessEntry()
		{
		}
	}
}
