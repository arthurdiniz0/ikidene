using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	public class TimedDespawner : MonoBehaviour
	{
		public float LifeSeconds;
		public bool StartTimerOnSpawn;
		public TimedDespawnerListener listener;
	}
}
