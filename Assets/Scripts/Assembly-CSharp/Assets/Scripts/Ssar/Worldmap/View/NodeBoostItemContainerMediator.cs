using SSAR.WorldMap.View;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Worldmap.View
{
	public class NodeBoostItemContainerMediator : Mediator
	{
		[Inject]
		public NodeBoostItemContainer view { get; set; }
	}
}
