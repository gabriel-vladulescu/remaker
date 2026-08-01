using UnityEngine;
using strange.extensions.context.api;

public class ApplicationDispatcherService
{
	public DispatcherRunner dispatcher;

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	[PostConstruct]
	public void Init()
	{
	}
}
