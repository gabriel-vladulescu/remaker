using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Ssar.DynamicAssets
{
	public class AssetBundleManager
	{
		private class AssetBundlesDownloaded
		{
			public string bundleName { get; set; }

			public string version { get; set; }

			public AssetBundlesDownloaded()
			{
			}

			public AssetBundlesDownloaded(string bundleName, string version)
			{
			}
		}

		public class ToFileDownloadHandler : DownloadHandlerScript
		{
			private int expected;

			private int received;

			private string filepath;

			private FileStream fileStream;

			private bool canceled;

			public ToFileDownloadHandler(byte[] buffer, string filepath)
				: base(null)
			{
			}

			protected override byte[] GetData()
			{
				return null;
			}

			protected override bool ReceiveData(byte[] data, int dataLength)
			{
				return false;
			}

			protected override float GetProgress()
			{
				return 0f;
			}

			protected override void CompleteContent()
			{
			}

			protected override void ReceiveContentLength(int contentLength)
			{
			}

			public void Cancel()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDownloadAssetBundlesIE_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetBundleManager _003C_003E4__this;

			private List<AssetsBundleData> _003Clist_003E5__2;

			private int _003Ccount_003E5__3;

			private string _003Cerror_003E5__4;

			private AssetsBundleData _003Clogic_003E5__5;

			private UnityWebRequest _003CunityWebRequest_003E5__6;

			private AsyncOperation _003CasyncOperation_003E5__7;

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
			public _003CDownloadAssetBundlesIE_003Ed__13(int _003C_003E1__state)
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

		private readonly string _host;

		private Action onFinish;

		private Action<string> onError;

		private Action<float> progress;

		private List<AssetsBundleData> listAssets;

		private AssetsVersionConfig assetsVersionConfig;

		private Dictionary<string, AssetBundle> dict;

		private List<AssetBundlesDownloaded> assetBundlesDownloadeds;

		private BigFileTransfer bigFileTransfer;

		public AssetBundle LoadBundle(string bundleName)
		{
			return null;
		}

		public void SetAssetBundlesData(AssetsVersionConfig assetsVersionConfig)
		{
		}

		public void DownloadAssetBundles(Action onFinish = null, Action<string> onError = null, Action<float> progress = null)
		{
		}

		[IteratorStateMachine(typeof(_003CDownloadAssetBundlesIE_003Ed__13))]
		private IEnumerator DownloadAssetBundlesIE()
		{
			return null;
		}

		public List<AssetsBundleData> AssetBundleRequireDownload()
		{
			return null;
		}

		private void Finish()
		{
		}

		private void DownloadComplete(AssetsBundleData assetsBundleData, UnityWebRequest www)
		{
		}

		private bool HasDownloaded(AssetsBundleData assetsBundleData)
		{
			return false;
		}

		private string GetDirectory()
		{
			return null;
		}

		private string AssetBundlesDownloadedPath()
		{
			return null;
		}

		private List<AssetBundlesDownloaded> AssetBundlesDownloadedData()
		{
			return null;
		}

		private void SaveDownloadedData(List<AssetBundlesDownloaded> assetBundlesDownloadeds)
		{
		}

		private void CheckDirectory()
		{
		}
	}
}
