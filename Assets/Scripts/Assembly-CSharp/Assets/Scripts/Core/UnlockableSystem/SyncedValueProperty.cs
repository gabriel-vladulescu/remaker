using Assets.Scripts.Core.UnlockableSystem.Cookies;

namespace Assets.Scripts.Core.UnlockableSystem
{
	public class SyncedValueProperty : Property
	{
		public interface Value
		{
			int get();

			void set(int value);
		}

		private int id;

		private Value syncedValue;

		private ActivationRule activationRule;

		private int activationValue;

		private int initialValue;

		private string[] tags;

		private object[] cookies;

		public SyncedValueProperty(int id, Value syncedValue, ActivationRule activationRule, int activationValue, int initialValue, string[] tags, object[] cookies)
		{
		}

		public int getId()
		{
			return 0;
		}

		public bool isActive()
		{
			return false;
		}

		public int getValue()
		{
			return 0;
		}

		public void setValue(int value)
		{
		}

		public string[] getTags()
		{
			return null;
		}

		public object[] getCookies()
		{
			return null;
		}

		public void reset()
		{
		}

		public ActivationRule getActivationRule()
		{
			return null;
		}

		public string tostring()
		{
			return null;
		}
	}
}
