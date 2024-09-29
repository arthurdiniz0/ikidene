using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueSystemController : MonoBehaviour
	{
		public DialogueDatabase initialDatabase;
		public DisplaySettings displaySettings;
		public PersistentDataSettings persistentDataSettings;
		public bool allowSimultaneousConversations;
		public bool includeSimStatus;
		public bool preloadResources;
		public bool instantiateDatabase;
		public bool dontDestroyOnLoad;
		public bool allowOnlyOneInstance;
		public DialogueTime.TimeMode dialogueTimeMode;
		public DialogueDebug.DebugLevel debugLevel;
	}
}
