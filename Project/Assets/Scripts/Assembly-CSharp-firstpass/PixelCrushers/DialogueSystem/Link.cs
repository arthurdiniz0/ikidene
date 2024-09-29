using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Link
	{
		public int originConversationID;
		public int originDialogueID;
		public int destinationConversationID;
		public int destinationDialogueID;
		public bool isConnector;
		public ConditionPriority priority;
	}
}
