using Scripts.Ssar.Arena;
using UnityEngine;

public class ArenaRankBorder : MonoBehaviour
{
	[SerializeField]
	private UITexture _botLeft;

	[SerializeField]
	private UITexture _rightLeft;

	[SerializeField]
	private UITexture _bot1;

	[SerializeField]
	private UITexture _bot2;

	[SerializeField]
	private UITexture _topLeft;

	[SerializeField]
	private UITexture _topRight;

	[SerializeField]
	private UITexture _top;

	[SerializeField]
	private UITexture _left1;

	[SerializeField]
	private UITexture _left2;

	[SerializeField]
	private UITexture _left3;

	[SerializeField]
	private UITexture _right1;

	[SerializeField]
	private UITexture _right2;

	[SerializeField]
	private UITexture _right3;

	[SerializeField]
	private Texture[] _bronze;

	[SerializeField]
	private Texture[] _silver;

	[SerializeField]
	private Texture[] _gold;

	[SerializeField]
	private Texture[] _platinum;

	[SerializeField]
	private Texture[] _diamond;

	[SerializeField]
	private Texture[] _champion;

	public void ShowRank(ArenaTier arenaTier)
	{
	}

	private Texture[] GetTierTextures(ArenaTier arenaTier)
	{
		return null;
	}

	private void SetBorder(Texture[] textures)
	{
	}
}
