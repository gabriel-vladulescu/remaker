using Artemis.Interface;
using SSAR.Navigation.View;

namespace SSAR.Navigation.Component
{
	public class MonsterNavigatorComponent : IComponent
	{
		private MonsterNavigatorView view;

		private bool isShow;

		public bool disableWhenClearStage;

		public MonsterNavigatorComponent(bool disableWhenClearStage = true)
		{
		}

		public void Hide()
		{
		}

		public void Show(float outOfViewX)
		{
		}

		public void Remove()
		{
		}
	}
}
