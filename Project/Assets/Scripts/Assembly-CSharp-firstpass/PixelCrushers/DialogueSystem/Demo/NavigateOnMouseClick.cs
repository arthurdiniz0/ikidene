using UnityEngine;

namespace PixelCrushers.DialogueSystem.Demo
{
	public class NavigateOnMouseClick : MonoBehaviour
	{
		public enum MouseButtonType
		{
			Left = 0,
			Right = 1,
			Middle = 2,
		}

		public string animatorSpeedParameter;
		public float stoppingDistance;
		public MouseButtonType mouseButton;
		public bool ignoreClicksOnUI;
	}
}
