using UnityEngine;

public interface AbsCardViewParameter
{
	string Title();

	string Icon();

	void OnClick(GameObject o);

	void OnCustomizeIcon(UISprite spriteIcon);
}
