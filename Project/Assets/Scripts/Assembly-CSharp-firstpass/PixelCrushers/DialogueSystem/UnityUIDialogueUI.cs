using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIDialogueUI : CanvasDialogueUI
	{
		public UnityUIRoot unityUIRoot;
		public UnityUIDialogueControls dialogue;
		public Graphic[] qteIndicators;
		public UnityUIAlertControls alert;
		public bool autoFocus;
		public bool allowStealFocus;
		public float autoFocusCheckFrequency;
		public bool findActorOverrides;
		public bool addEventSystemIfNeeded;
	}
}
