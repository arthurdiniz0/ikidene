using PixelCrushers;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIInputField : UIPanel
	{
		public Graphic panel;
		public UITextField label;
		public UIInputField inputField;
		public KeyCode acceptKey;
		public KeyCode cancelKey;
		public bool showTouchScreenKeyboard;
		public UnityEvent onAccept;
		public UnityEvent onCancel;
	}
}
