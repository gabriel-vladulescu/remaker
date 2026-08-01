using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster3100
{
	public class GateOfBabylon
	{
		private GateOfBabylonConfig config;

		private GateOfBabylonDependencies dependencies;

		private Vector2[] spawnerPos;

		private List<Vector2> tempSpawnerPos;

		public int SideValue => 0;

		public int DirectionValue => 0;

		public GateOfBabylon(GateOfBabylonConfig config, GateOfBabylonDependencies dependencies)
		{
		}

		public void OnCast()
		{
		}

		public void Update(float dt)
		{
		}

		private void Init()
		{
		}

		private void InitSpawners()
		{
		}

		private void SpawnProjectile(Vector2 pos, int index)
		{
		}

		private Vector2 GetProjectileSpawnPosition(int index)
		{
			return default(Vector2);
		}

		private Vector2 GetProjectileVelocity()
		{
			return default(Vector2);
		}

		private void SpawnGateVfx()
		{
		}

		private Vector2 GetGateVfxOffset()
		{
			return default(Vector2);
		}

		private void SpawnStartupProjectileVfx(Vector2 pos, int index)
		{
		}

		private Vector2 ConvertToVfxOffset(Vector2 offset)
		{
			return default(Vector2);
		}
	}
}
