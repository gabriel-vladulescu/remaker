using System;
using System.Collections.Generic;

namespace SSAR.BattleSystem.Effect
{
	[Serializable]
	public class EffectEditorInfo
	{
		public string path;

		public StatusEffectLayer effectPos;

		public int durationInFrames;

		public int startAtFrame;

		public List<CharOffset> offsets;

		public List<JointInfo> jointInfos;

		public List<CharScale> scaleInfos;
	}
}
