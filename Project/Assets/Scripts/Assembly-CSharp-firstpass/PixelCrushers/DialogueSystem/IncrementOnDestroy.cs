using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class IncrementOnDestroy : MonoBehaviour
	{
		public enum IncrementOn
		{
			Destroy = 0,
			Disable = 1,
		}

		public IncrementOn incrementOn;
		public string variable;
		public int increment;
		public int min;
		public int max;
		public string alertMessage;
		public float alertDuration;
		public Condition condition;
		public UnityEvent onIncrement;
	}
}
