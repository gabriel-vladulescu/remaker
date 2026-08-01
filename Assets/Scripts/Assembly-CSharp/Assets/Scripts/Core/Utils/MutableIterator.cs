using System.Collections;

namespace Assets.Scripts.Core.Utils
{
	public class MutableIterator
	{
		private int index;

		private int count;

		public int Index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Count => 0;

		public void Reset()
		{
		}

		public void Init(int count)
		{
		}

		public void Init(ICollection list)
		{
		}

		public bool Active()
		{
			return false;
		}

		public void Next()
		{
		}

		public void OnRemove(int i)
		{
		}
	}
}
