using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class InputDeviceManager : MonoBehaviour
	{
		public InputDevice inputDevice;
		public KeyCode[] joystickKeyCodesToCheck;
		public string[] joystickButtonsToCheck;
		public string[] joystickAxesToCheck;
		public float joystickAxisThreshold;
		public string[] keyButtonsToCheck;
		public KeyCode[] keyCodesToCheck;
		public bool alwaysAutoFocus;
		public bool detectMouseControl;
		public float mouseMoveThreshold;
		public bool controlCursorState;
		public bool enforceCursorOnPause;
		public bool controlGraphicRaycasters;
		public KeyCode[] backKeyCodes;
		public string[] backButtons;
		public bool singleton;
		public UnityEvent onUseKeyboard;
		public UnityEvent onUseJoystick;
		public UnityEvent onUseMouse;
		public UnityEvent onUseTouch;
	}
}
