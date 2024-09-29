using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class LoadLevel : FsmStateAction
	{
		public FsmString levelName;
		public FsmString spawnpoint;
		public bool additive;
		public bool async;
		public bool resetDialogueDatabase;
		public bool resetToInitialDatabase;
		public bool applyPersistentData;
		public int framesToWaitBeforeApplyData;
		public FsmEvent loadedEvent;
		public FsmBool dontDestroyOnLoad;
	}
}
