using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncIntArray : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmArray playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
