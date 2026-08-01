using UnityEngine;

namespace Assets.Scripts.Utils
{
	public interface LoadModelLogic
	{
		void Prepare();

		void AnchorUIAndModelPosition(GameObject model);

		void ModifyInfoAfterInstantiate(GameObject model);

		GameObject ModelRoot();

		bool Instantly();

		string GetCharacterPrefabPath(int groupId, int subId);
	}
}
