using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DataService
{
	public delegate void PreSaving(bool pauseStatus);

	public delegate void PreQuiting();

	private Dictionary<string, object> storage;

	[Inject]
	public ApplicationDispatcherService appService { get; set; }

	public event PreSaving PreSavingEvent;

	public event PreQuiting PreQuitingEvent;

	public void LoadData()
	{
	}

	[PostConstruct]
	public void Init()
	{
	}

	public void OnQuit()
	{
	}

	public void OnPause(bool pauseStatus)
	{
	}

	public void Save(string prefKey, object instance)
	{
	}

	public T Load<T>(string preKey)
	{
		return default(T);
	}

	public void Flush()
	{
	}
}
