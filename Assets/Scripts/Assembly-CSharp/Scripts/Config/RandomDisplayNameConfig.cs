using System.Collections.Generic;

namespace Scripts.Config
{
	public class RandomDisplayNameConfig : IConfig
	{
		private List<RandomDisplayFirstNameValue> m_firstName;

		private List<RandomDisplayLastNameValue> m_lastName;

		public void OnMapValue(string content)
		{
		}

		public List<RandomDisplayFirstNameValue> GetFirstNames()
		{
			return null;
		}

		public List<RandomDisplayLastNameValue> GetLastName()
		{
			return null;
		}
	}
}
