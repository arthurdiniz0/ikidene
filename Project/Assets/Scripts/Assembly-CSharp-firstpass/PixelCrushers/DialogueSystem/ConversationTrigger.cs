using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationTrigger : ConversationStarter
	{
		public Transform actor;
		public DialogueTriggerEvent trigger;
		public bool stopConversationOnTriggerExit;
	}
}
