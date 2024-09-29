using UnityEngine;

namespace PixelCrushers
{
	public class AutoSaveLoad : MonoBehaviour
	{
		public int saveSlotNumber;
		public int[] dontSaveInScenes;
		public bool loadOnStart;
		public bool saveOnQuit;
		public bool saveOnPause;
		public bool saveOnLoseFocus;
	}
}
