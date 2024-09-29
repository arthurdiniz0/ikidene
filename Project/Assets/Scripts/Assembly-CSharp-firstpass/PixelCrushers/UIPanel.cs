using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class UIPanel : MonoBehaviour
	{
		public enum StartState
		{
			GameObjectState = 0,
			Open = 1,
			Closed = 2,
		}

		public GameObject firstSelected;
		public float focusCheckFrequency;
		public float refreshSelectablesFrequency;
		public bool selectPreviousOnDisable;
		public string showAnimationTrigger;
		public string hideAnimationTrigger;
		public StartState startState;
		public UnityEvent onOpen;
		public UnityEvent onClose;
		public UnityEvent onBackButtonDown;
	}
}
