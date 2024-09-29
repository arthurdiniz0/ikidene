using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationStarter : DialogueEventStarter
	{
		public string conversation;
		public Condition condition;
		public bool skipIfNoValidEntries;
		public bool exclusive;
		public Transform conversant;
		public bool useConversationTitlePicker;
		public DialogueDatabase selectedDatabase;
	}
}
