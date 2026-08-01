using UnityEngine;

public class ItemInfo3DCoreView : MonoBehaviour
{
	public enum ResizeType
	{
		NONE = 0,
		BASE_WIDTH = 1,
		BASE_HEIGHT = 2
	}

	public Renderer icon;

	public TextMesh tierLb;

	public GameObject btn_detail;

	private UIAtlas miscAtlas;

	private INGUIAtlas _atlas;

	private ItemInfo itemInfo;

	private void Awake()
	{
	}

	public void EnableViewInfo(bool enable)
	{
	}

	private void ViewDetail(GameObject go)
	{
	}

	private void ShowInfo()
	{
	}

	public void Show(ItemInfo itemData)
	{
	}

	private void SetSprite(string spriteName, Renderer rend, INGUIAtlas atlas, ResizeType resizeType = ResizeType.NONE)
	{
	}

	private void SetTexture(Material mat, UISpriteData spriteData)
	{
	}

	private void Resize(Transform trans, UISpriteData spriteData, ResizeType resizeType)
	{
	}
}
