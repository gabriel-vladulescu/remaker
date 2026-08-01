using System;
using UnityEngine;

public static class InterfaceUtils
{
	public class DisplayItemElements
	{
		public UILabel lbDesc;

		public UILabel lbTier;

		public UILabel lbRarity;

		public UILabel lbEnhance;

		public UISprite spIcon;

		public UISprite spRarity;

		public UISprite spBackground;

		public GameObject wgTier;

		public DisplayItemElements(UILabel lbDesc, UILabel lbTier, UISprite spIcon, UISprite spRarity, UISprite spBackground, GameObject wgTier)
		{
		}

		public DisplayItemElements(UILabel lbDesc, UILabel lbTier, UILabel lbRarity, UILabel lbEnhance, UISprite spIcon, UISprite spRarity, UISprite spBackground, GameObject wgTier)
		{
		}
	}

	public class DisplayItemParameters
	{
		public Action callback;

		public bool autoResize;

		public int iconSize;

		public DisplayItemParameters()
		{
		}

		public DisplayItemParameters(Action callback)
		{
		}

		public DisplayItemParameters(bool autoResize, int iconSize)
		{
		}

		public DisplayItemParameters(bool autoResize)
		{
		}

		public DisplayItemParameters(Action callback, bool autoResize)
		{
		}
	}

	public static void ShowReceivedItem(ItemInfo itemInfo, DisplayItemElements elements, DisplayItemParameters parameters)
	{
	}

	private static void ResizeItemIcon(DisplayItemElements elements, DisplayItemParameters parameters)
	{
	}
}
