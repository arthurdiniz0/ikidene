using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class GameSaver : MonoBehaviour
	{
		public enum FunctionOnUse
		{
			None = 0,
			Save = 1,
			Load = 2,
			Restart = 3,
		}

		public string playerPrefsKey;
		public int slot;
		public FunctionOnUse functionOnUse;
		public bool includeAllItemData;
		public bool includeLocationData;
		public bool includeSimStatus;
		public string startingLevel;
		public bool dontDestroyOnLoad;
	}
}
