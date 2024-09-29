using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	public class PlayerSpawner : MonoBehaviour
	{
		public Transform PlayerPrefab;
		public Transform RespawnParticlePrefab;
		public Vector3 RespawnParticleOffset;
		public float RespawnDelay;
		public Vector3 spawnPosition;
		public bool followPlayer;
	}
}
