using System.Collections.Generic;
using Assets.Scripts.Ssar.Common.System.Resources;
using SSAR.BattleSystem.Camera;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public interface Environment
	{
		List<Character> FindNearbyCharacters(Character subject, Vector3 relativePosition, float distance, params FindingFilter[] filter);

		List<Character> FindCharactersWithIn(Character subject, Vector3 center, Vector2 size, params FindingFilter[] filter);

		float MostLeftOfMap();

		float MostRightOfMap();

		float CeilOfMap();

		float GroundOfMap(float positionOnXAxis);

		void PlayCameraFx(Character caster, EventFrame ef);

		void PlaySfx(EventFrame ef);

		void FadeoutSfx(string path);

		GameObject InstantiateGameObject(GameObject prefab);

		GameObject InstantiateGameObject(string prefabPath);

		GameObject InstantiateGameObject(string prefabPath, GameObject prefab);

		void RecycleVfx(GameObject vfx);

		ResourcesLoader ResourcesLoader();

		Vector4 ViewPortBoundaryInWorldPosition();

		void StopCameraFromTrackingTargets();

		void StartCameraToTrackPosition(Vector2 position);

		void StartCameraToTrackEntity(int entityId);

		void CinematicControl(CinematicCameraControl control);

		bool IsHoldingAttack();

		void StopCameraFromTrackingOnYAxis();

		void StartCameraToTrackingOnYAxis();
	}
}
