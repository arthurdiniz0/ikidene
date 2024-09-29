using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class RangeTrigger : MonoBehaviour
	{
		public Condition condition;
		public GameObject[] gameObjects;
		public Component[] components;
		public UnityEvent onEnter;
		public UnityEvent onExit;
	}
}
