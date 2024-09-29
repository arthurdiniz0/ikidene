using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class BarkGroupMember : MonoBehaviour
	{
		public string groupId;
		public bool evaluateIdEveryBark;
		public float forcedHideDelay;
		public bool queueBarks;
		public float minDelayBetweenQueuedBarks;
		public float maxDelayBetweenQueuedBarks;
	}
}
