using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.Shop.Enum;
using SSAR.Shop.View;
using Scripts.Config;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class UserResourcesView : strange.extensions.mediation.impl.View
	{
		[CompilerGenerated]
		private sealed class _003CShortCut_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string category;

			public ShopTabType defaultTab;

			private List<BundlePackageProductInfo> _003Cp_003E5__2;

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
			public _003CShortCut_003Ed__66(int _003C_003E1__state)
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

		public UILabel lb_title;

		public UILabel lb_crystal;

		public UILabel lb_soul;

		public UILabel lb_stamina;

		public UILabel lb_videoPoint;

		public UILabel lb_staminaRecovery;

		public UILabel lb_vodRecovery;

		public UILabel lb_skillPoint;

		public UILabel lb_arenaKey;

		public UILabel lb_arenaKeyRecovery;

		public UIWidget resourcesContainer;

		public UserDataView UserDataView;

		public UISprite sp_border;

		public GameObject userDataContainer;

		public GameObject titleContainer;

		public GameObject btn_back;

		public GameObject btn_crystal;

		public GameObject btn_soul;

		public GameObject btn_stamina;

		public GameObject btn_skillPoint;

		public GameObject btn_setting;

		public GameObject btn_vod;

		public GameObject btn_arenaKey;

		public GameObject wg_fxSave;

		public TweenFill fxSave;

		public TweenAlpha tweenSave;

		public UIWidget wg_staminaRecovery;

		public UIWidget wg_arenaKeyRecovery;

		public UIWidget wg_vodRecovery;

		public GameObject wg_stamina;

		public GameObject wg_videoPoint;

		public GameObject wg_crystal;

		public GameObject wg_soul;

		public GameObject wg_skillPoint;

		public GameObject wg_arenaKey;

		public GameObject icon_videoPoint;

		public GameObject icon_videoTicket;

		public UITable table_resources;

		public MainSceneDoubleExpBuff MainSceneDoubleExpBuff;

		private InstantiateUserResourcesParameter parameter;

		private AutoSaveFxController autoSaveFxController;

		public Preset preset;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public void Init(InstantiateUserResourcesParameter parameter)
		{
		}

		public void EnableResouces(bool enable)
		{
		}

		public void EnableSetting(bool enable)
		{
		}

		public void OnSave()
		{
		}

		private void UpdateResources()
		{
		}

		private void UpdateCrystal(int crystal)
		{
		}

		private void UpdateExp(int exp)
		{
		}

		private void UpdateSoul(int soul)
		{
		}

		private void UpdateStamina()
		{
		}

		private void UpdateArenaKey()
		{
		}

		private void UpdateVideoPoint()
		{
		}

		private void UpdateSkillPoint()
		{
		}

		private void CheckShowTittleOrPlayerData()
		{
		}

		private void SetTableAnchor(GameObject leftTarget)
		{
		}

		private void Back(GameObject o)
		{
		}

		private void Update()
		{
		}

		private void BuyStamina(GameObject o)
		{
		}

		private void BuyCrystal(GameObject o)
		{
		}

		private void BuySoul(GameObject o)
		{
		}

		private void Setting(GameObject o)
		{
		}

		private void BuyVOD(GameObject o)
		{
		}

		private void BuyArenaKey(GameObject o)
		{
		}

		[IteratorStateMachine(typeof(_003CShortCut_003Ed__66))]
		private IEnumerator ShortCut(string category, ShopTabType defaultTab)
		{
			return null;
		}

		public void EnableDoubleExpbuff()
		{
		}

		private void BuySkillPoint(GameObject o)
		{
		}
	}
}
