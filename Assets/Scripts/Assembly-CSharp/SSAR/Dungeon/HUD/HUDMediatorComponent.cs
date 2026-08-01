using Artemis.Interface;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	public class HUDMediatorComponent : IComponent
	{
		private HUDView view;

		private UIFollowTarget ft;

		private GameObject go;

		public HUDMediatorComponent(float maxHealth, float curHealth, Transform pivot, HpBarType hpBarType = HpBarType.SMALL, bool isAlly = false)
		{
		}

		public void ChangeTargetTo(CachingComponent cachingComponent)
		{
		}

		public void ChangeHp(ChangeHpParameter param)
		{
		}

		public void UpdateHpBar(float curHp, float maxHp)
		{
		}

		public void ShowEffectText(string effect, HUDTextInfo hudInfo)
		{
		}

		public void SetIsAlly(bool value)
		{
		}

		public void SetDisplayHp(bool val)
		{
		}

		public void ForceAlwaysVisible()
		{
		}

		public void Remove()
		{
		}

		public void AddObjectOnHead(GameObject[] objects, string text)
		{
		}

		public void AddObjectOnHead(GameObject objects, string text)
		{
		}

		public void DisplayName(string name)
		{
		}
	}
}
