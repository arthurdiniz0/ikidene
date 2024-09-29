using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	public class BehaviorManager : MonoBehaviour
	{
		public enum ExecutionsPerTickType
		{
			NoDuplicates = 0,
			Count = 1,
		}

		[SerializeField]
		private UpdateIntervalType updateInterval;
		[SerializeField]
		private float updateIntervalSeconds;
		[SerializeField]
		private ExecutionsPerTickType executionsPerTick;
		[SerializeField]
		private int maxTaskExecutionsPerTick;
	}
}
