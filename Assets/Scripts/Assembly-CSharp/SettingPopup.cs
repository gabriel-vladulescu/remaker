using System;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopup : BasePopup
{
	private class UID
	{
		public List<CharacterInfo> c;

		public UID()
		{
		}

		public UID(List<CharacterInfo> characterInfos)
		{
		}
	}

	private class CharacterInfo
	{
		public string n;

		public int gid;

		public int t;

		public string f;

		public string d;

		public CharacterInfo(string firebaseUID, string deviceId, string displayName, int groupId, int characterCreationTime)
		{
		}
	}

	public UILabel lb_music;

	public UILabel lb_sound;

	public UILabel lb_language;

	public UILabel lb_fps;

	public UILabel lb_version;

	public UILabel lb_configVersion;

	public UILabel lb_userId;

	public UILabel lb_cooldown;

	public UILabel lb_buttonLoad;

	public UILabel lb_noti;

	public UILabel lb_damage;

	public GameObject btn_load;

	public GameObject btn_save;

	public GameObject btn_music;

	public GameObject btn_sound;

	public GameObject btn_language;

	public GameObject btn_close;

	public GameObject btn_fps;

	public GameObject btn_copyUID;

	public GameObject btn_giftCode;

	public GameObject btn_control;

	public GameObject btn_noti;

	public GameObject btn_damage;

	public GameObject btn_contact;

	public GameObject btn_policy;

	private float time;

	private float DELAY_UIPATE;

	private Action onHide;

	protected override void Awake()
	{
	}

	private void ContactUs(GameObject go)
	{
	}

	private new void Hide(GameObject o)
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	public void Show(Action onClose)
	{
	}

	private void UpdateData()
	{
	}

	private void ClickSound(GameObject o)
	{
	}

	private void ClickMusic(GameObject o)
	{
	}

	private void ClickFps(GameObject o)
	{
	}

	private void Notification(GameObject go)
	{
	}

	private void ClickDamage(GameObject go)
	{
	}

	private void GiftCode(GameObject o)
	{
	}

	private void Control(GameObject go)
	{
	}

	private void ClickLanguage(GameObject o)
	{
	}

	private bool IsMuteSound()
	{
		return false;
	}

	private bool IsMuteMusic()
	{
		return false;
	}

	private bool IsShowFps()
	{
		return false;
	}

	private bool IsDisableNotification()
	{
		return false;
	}

	private bool IsDisableDamageText()
	{
		return false;
	}

	private string GetLanguage()
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateLoadDataCooldown()
	{
	}

	private bool HasLinkWithSocial()
	{
		return false;
	}

	public int LoadDataCooldown()
	{
		return 0;
	}
}
