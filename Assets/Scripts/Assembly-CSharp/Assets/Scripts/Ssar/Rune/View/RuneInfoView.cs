using System;
using Ssar.Rune.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class RuneInfoView : MonoBehaviour
	{
		public GameObject wg_item;

		public GameObject wgLevelUpStat;

		public GameObject btn_close;

		public GameObject btn_sell;

		public GameObject btn_disassemble;

		public GameObject btn_synthesize;

		public GameObject btn_oke;

		public GameObject btn_equip;

		public GameObject btn_craft;

		public UILabel lb_nextRuneName;

		public UILabel[] lb_stat;

		public UILabel[] lb_nextRarityStat;

		public UISprite sp_runeNextLevel;

		public UISprite sp_qualityNextLevel;

		public UILabel lb_maxStack;

		public UILabel lb_info;

		public GameObject statsContainer;

		private RuneSimpleInfoView runeSimpleInfoView;

		private global::Ssar.Rune.Model.Rune rune;

		private Action onClose;

		private void Awake()
		{
		}

		public void Show(global::Ssar.Rune.Model.Rune rune, ViewRuneInfoType viewRuneInfoType)
		{
		}

		public void CheckAndActiveBtnSynthesize(ViewRuneInfoType viewRuneInfoType)
		{
		}

		public void CheckAndActiveBtnDisassemble(ViewRuneInfoType viewRuneInfoType)
		{
		}

		public void CheckAndActiveBtnCraft(ViewRuneInfoType viewRuneInfoType)
		{
		}

		public void ListenerOnClose(Action action)
		{
		}

		private void Init()
		{
		}

		private void Close(GameObject o)
		{
		}

		private void Sell(GameObject o)
		{
		}

		private void Combine(GameObject o)
		{
		}

		private void Disassemble(GameObject o)
		{
		}

		public void Hide()
		{
		}

		private void Equip(GameObject o)
		{
		}

		public void Craft(GameObject o)
		{
		}

		private void UpdateStat()
		{
		}

		private void UpdateNextRariryStat()
		{
		}

		private void ShowRuneInfo()
		{
		}
	}
}
