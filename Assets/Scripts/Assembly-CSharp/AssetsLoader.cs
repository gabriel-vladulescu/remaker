using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

public class AssetsLoader
{
	private class ProcessMultiAssetsRequest
	{
		private int index;

		private LoadMultiAssetsRequest request;

		private AssetsLoader loader;

		public ProcessMultiAssetsRequest(AssetsLoader loader, LoadMultiAssetsRequest request)
		{
		}

		public void Process()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CBundleLoad_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetsLoader _003C_003E4__this;

		public LoadAssetRequest request;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CBundleLoad_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CResourcesLoad_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetsLoader _003C_003E4__this;

		public LoadAssetRequest request;

		private ResourceRequest _003CresourceRequest_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CResourcesLoad_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartQueue_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetsLoader _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartQueue_003Ed__12(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private Dictionary<string, object> cachedObject;

	private LoadAssetsMode mode;

	private AssetsVersionConfig assetsVersionConfig;

	private bool isStartQueue;

	private Queue<LoadAssetRequest> queue;

	private string bundleAssetsUrl;

	public void SetLoadAssetsMode(LoadAssetsMode mode)
	{
	}

	public void SetAssetVersionConfig(AssetsVersionConfig config)
	{
	}

	public void SetBundleAssetsUrl(string url)
	{
	}

	public void Load(LoadAssetRequest request)
	{
	}

	public T Load<T>(string resourcesPath) where T : UnityEngine.Object
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartQueue_003Ed__12))]
	private IEnumerator StartQueue()
	{
		return null;
	}

	public void Load(LoadMultiAssetsRequest request)
	{
	}

	[IteratorStateMachine(typeof(_003CResourcesLoad_003Ed__14))]
	private IEnumerator ResourcesLoad(LoadAssetRequest request)
	{
		return null;
	}

	private AssetsVersionConfig GetAssetsVersionConfig()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBundleLoad_003Ed__16))]
	private IEnumerator BundleLoad(LoadAssetRequest request)
	{
		return null;
	}

	private object GetCachedObject(string resourcePath)
	{
		return null;
	}

	public string ResourcePathToBundlePath(string resourcesPath, bool useExt = true)
	{
		return null;
	}

	public string GetBundleName(string resourcePath)
	{
		return null;
	}

	public void AddToCache(string resourcePath, object obj)
	{
	}

	public void UnLoadAllBundle()
	{
	}
}
