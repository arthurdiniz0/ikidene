using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUITextFieldUI : MonoBehaviour
	{
		public Graphic panel;
		public Text label;
		public InputField textField;
		public KeyCode acceptKey;
		public KeyCode cancelKey;
		public bool showTouchScreenKeyboard;
		public UnityEvent onAccept;
		public UnityEvent onCancel;
	}
}
