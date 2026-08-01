using SSAR.View;

namespace SSAR.SkillSystem.View
{
	public class SkillPresetTabNotify : AbsButtonNofity
	{
		public Preset tabtype;

		protected override bool IsNotify()
		{
			return false;
		}
	}
}
