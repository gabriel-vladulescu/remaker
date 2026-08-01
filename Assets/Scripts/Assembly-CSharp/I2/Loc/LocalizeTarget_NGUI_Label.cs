using UnityEngine;

namespace I2.Loc
{
	public class LocalizeTarget_NGUI_Label : LocalizeTarget<UILabel>
	{
		private NGUIText.Alignment mAlignment_RTL;

		private NGUIText.Alignment mAlignment_LTR;

		private bool mAlignmentWasRTL;

		private bool mInitializeAlignment;

		static LocalizeTarget_NGUI_Label()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = null;
			secondaryTerm = null;
		}

		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}
	}
}
