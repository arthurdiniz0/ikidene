using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	public class TriggeredDespawner : MonoBehaviour
	{
		public EventDespawnSpecifics invisibleSpec;
		public EventDespawnSpecifics mouseOverSpec;
		public EventDespawnSpecifics mouseClickSpec;
		public EventDespawnSpecifics collisionSpec;
		public EventDespawnSpecifics triggerEnterSpec;
		public EventDespawnSpecifics triggerExitSpec;
		public EventDespawnSpecifics collision2dSpec;
		public EventDespawnSpecifics triggerEnter2dSpec;
		public EventDespawnSpecifics triggerExit2dSpec;
		public EventDespawnSpecifics onClickSpec;
		public TriggeredDespawnerListener listener;
	}
}
