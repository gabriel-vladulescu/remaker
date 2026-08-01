using SSAR.SkillSystem.Model;
using Scripts.Config;
using UnityEngine;

public class SkillItemView : MonoBehaviour
{
	public UILabel lb_shortName;

	public UILabel lb_point;

	public UILabel lb_unLocklevel;

	public UISprite sp_icon;

	public GameObject widget_point;

	public GameObject widget_lock;

	public GameObject widget_select;

	public TweenScale TweenScale;

	public GameObject wgBlock;

	public ParticelRunCircle ParticelRunCircle;

	private Material grayScaleMaterial;

	public CharacterActiveSkillStat characterActiveSkillStat;

	private MainCharacterData mainCharacterData;

	private void Awake()
	{
	}

	public void Show(MainCharacterData mainCharacterData, CharacterActiveSkillStat activeSkillStat, ActiveSkillRuneData runeData)
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	public void Hide()
	{
	}

	public bool IsUnLock()
	{
		return false;
	}

	public void LockAndDisableIcon(int level)
	{
	}

	public void SetActiveWgBlock(bool active)
	{
	}

	public void SetActiveWgCanSelect(bool active)
	{
	}
}
