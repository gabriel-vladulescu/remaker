using System;

namespace SSAR.Entry.Model
{
	public class GuestLogin : AbsLogin
	{
		protected override void LoadData(Action<string, UserData> callBack)
		{
		}

		protected override UserDataType Type()
		{
			return default(UserDataType);
		}

		protected override bool EnableAuthticateWhenSave()
		{
			return false;
		}

		public override void SignOut()
		{
		}
	}
}
