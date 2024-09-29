using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class PersistentDestructible : MonoBehaviour
	{
		public enum RecordOn
		{
			Destroy = 0,
			Disable = 1,
		}

		public RecordOn recordOn;
		public string variableName;
		public GameObject spawnWhenDestroyed;
	}
}
