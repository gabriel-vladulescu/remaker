using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	public class HUDView : MonoBehaviour
	{
		private class BubblePopup
		{
			private TweenAlpha bubblePopupTween;

			private UITable table;

			private GameObject tableContainer;

			private UISprite bg;

			private GameObject bubble;

			private UIFont font;

			public BubblePopup(GameObject parent)
			{
			}

			public void AddObjectOnHead(GameObject[] obj, string text)
			{
			}

			public void ClearObjectObHead()
			{
			}

			private void AddDescription(string text)
			{
			}

			private GameObject[] GenerateListObject(GameObject[] o)
			{
				return null;
			}

			private GameObject AddIconPlus()
			{
				return null;
			}
		}

		private HUDText damageText;

		private HUDText effectText;

		private UIProgressBar healthBarSlider;

		private UILabel lb_character;

		private bool isAlly;

		private bool isVisible;

		private bool isUpdateVisible;

		private float visibleTime;

		private float damageTakenVisibleTime;

		private bool enterAction;

		private HpBarType hpBarType;

		public const float VISIBLE_TIME = 5f;

		private const string FG_PREFIX = "fg-hp-";

		private const string ALLY = "ally";

		private const string ENEMY = "enemy";

		private const string POSTFIX_SMALL = "-small";

		private const string POSTFIX_MID = "-mid";

		private bool isCooldown;

		private GameObject head;

		private BubblePopup bubblePopup;

		public void Initialization(float maxHealth, float curHealth, HpBarType hpBarType, bool isAlly, bool isUpdateVisible)
		{
		}

		public void DisplayName(string name)
		{
		}

		public void AddObjectOnHead(GameObject[] o, string text)
		{
		}

		public void ForceUpdateHpBar(float percent)
		{
		}

		public void ForceSetupUpdateVisible(bool value)
		{
		}

		private void Update()
		{
		}

		private void NotifyDamage(ChangeHpParameter param)
		{
		}

		private HUDTextType GetDmgTextType(DamageType damageType)
		{
			return default(HUDTextType);
		}

		public void NotifyEffect(string effect, HUDTextInfo hudInfo)
		{
		}

		public void ChangeHp(ChangeHpParameter param)
		{
		}

		public void UpdateHpBar(float curHp, float maxHp)
		{
		}

		public void SetIsAlly(bool value)
		{
		}

		public void SetDisplayHpBar(bool value)
		{
		}

		public void HideTextEffect()
		{
		}

		private void SetHpColor()
		{
		}

		public void RemoveHealthBar()
		{
		}

		public void RemoveAll()
		{
		}

		private void SetVisible(bool val)
		{
		}

		public void SetDisplayDamageTakenBar(bool val)
		{
		}
	}
}
