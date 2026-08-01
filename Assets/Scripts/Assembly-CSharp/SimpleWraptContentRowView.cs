using strange.extensions.mediation.impl;

public abstract class SimpleWraptContentRowView : View
{
	public int index;

	protected WrapContentData data;

	public void Show(WrapContentData data, int index)
	{
	}

	public abstract void OnShow(WrapContentData data, int index);

	public abstract void Hide();
}
