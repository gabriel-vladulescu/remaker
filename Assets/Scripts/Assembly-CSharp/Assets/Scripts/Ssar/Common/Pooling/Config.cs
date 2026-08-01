using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Common.Pooling
{
	public class Config : IEnumerable<Definition>, IEnumerable
	{
		private List<Definition> definitions;

		public Config(Definition[] definitionsArray)
		{
		}

		public void AddDefinition(Definition def)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<Definition> GetEnumerator()
		{
			return null;
		}
	}
}
