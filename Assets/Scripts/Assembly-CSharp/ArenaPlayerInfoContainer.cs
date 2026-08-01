using Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena;
using UnityEngine;

public class ArenaPlayerInfoContainer : MonoBehaviour
{
	[SerializeField]
	private UILabel _playerName;

	[SerializeField]
	private UILabel _characterName;

	[SerializeField]
	private UILabel _playerLevel;

	[SerializeField]
	private UILabel _playerPower;

	[SerializeField]
	private UISprite _division;

	[SerializeField]
	private ArenaRankBorder _rankBorder;

	[SerializeField]
	private ArenaCharacterSplashView _characterSplash;

	public void Show(ArenaModeParameter arenaModeParameter, bool isRival)
	{
	}

	private string GetHeroName(int groupId)
	{
		return null;
	}
}
