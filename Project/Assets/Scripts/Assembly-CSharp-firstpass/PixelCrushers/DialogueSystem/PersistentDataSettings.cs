using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class PersistentDataSettings
	{
		public PersistentDataManager.RecordPersistentDataOn recordPersistentDataOn;
		public bool includeActorData;
		public bool includeAllItemData;
		public bool includeLocationData;
		public bool includeStatusAndRelationshipData;
		public bool includeAllConversationFields;
		public string saveConversationSimStatusWithField;
		public string saveDialogueEntrySimStatusWithField;
		public int asyncGameObjectBatchSize;
		public int asyncDialogueEntryBatchSize;
		public bool initializeNewVariables;
	}
}
