using System;

namespace SSAR.Entry.Model
{
	public abstract class AbsLogin
	{
		private Action<bool, string> action;

		public AbsLogin()
		{
		}

		public void Listen(Action<bool, string> loginCallBack)
		{
		}

		public void Login()
		{
		}

		public void SaveDataToFireBase(bool checkDeviceId = true)
		{
		}

		private void Save(UserData localData, UserData cloudData, bool checkDeviceId)
		{
		}

		private bool HasSingedInAnotherDevice(UserData localData, UserData cloudData)
		{
			return false;
		}

		public void CompareData(UserData userData)
		{
		}

		protected abstract void LoadData(Action<string, UserData> callBack);

		protected abstract UserDataType Type();

		protected abstract bool EnableAuthticateWhenSave();

		public abstract void SignOut();
	}
}
