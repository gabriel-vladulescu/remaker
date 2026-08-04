namespace Assets.Scripts.Ssar.Dungeon
{
	// Not part of the original game. The real game's dungeon-start signal
	// chain (DungeonSignalManager) is ~90 interconnected signals deep and
	// almost certainly carries hero/dungeon selection through its
	// Firestore-backed save-data system (Assets/Scripts/Ssar/DataManager),
	// which is its own large, cloud-dependent subsystem out of scope here.
	//
	// This is the minimal contract between the lobby/selection flow (which
	// picks a dungeon + hero loadout) and InitDungeonSystemCmd (which spawns
	// the character and boots the dungeon): set these static fields, then
	// load the Dungeon scene. Defaults match what InitDungeonSystemCmd was
	// previously hardcoded to, so opening Dungeon.unity directly (without
	// going through a lobby) still works unchanged.
	public static class DungeonSelection
	{
		public static int HeroGroupId = 1;
		public static int HeroSubId = 1;
		public static int HeroLevel = 1;

		// Matches Resources/characters/{HeroGroupId}/{HeroSubId}/ folder layout.
		public static string HeroPrefabResourcePath = "characters/group_1/1/1_1_Prefab";

		// Set for real now by SimpleDungeonSelectView (SelectionScene's
		// dungeon-page-with-levels screen). Still unread by
		// InitDungeonSystemCmd though - no real level-generation exists yet
		// (see DungeonFactory/DefaultStage/DefaultEnvironment), so picking
		// different dungeons doesn't yet change what Dungeon.unity looks
		// like. That's the next piece once DungeonFactory is implemented.
		public static int DungeonId = 1;
	}
}
