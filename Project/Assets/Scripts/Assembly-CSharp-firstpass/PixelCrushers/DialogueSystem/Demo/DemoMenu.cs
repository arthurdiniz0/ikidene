using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem.Demo
{
	public class DemoMenu : MonoBehaviour
	{
		[TextAreaAttribute]
		public string startMessage;
		public KeyCode menuKey;
		public GUISkin guiSkin;
		public bool closeWhenQuestLogOpen;
		public UnityEvent onOpen;
		public UnityEvent onClose;
	}
}
