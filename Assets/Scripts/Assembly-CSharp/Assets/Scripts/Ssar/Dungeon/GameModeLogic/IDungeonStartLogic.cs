using System.Collections;
using strange.extensions.injector.api;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic
{
	public interface IDungeonStartLogic
	{
		IEnumerator EffectPrepare(IInjectionBinder injectionBinder);

		void OnDungeonStart();
	}
}
