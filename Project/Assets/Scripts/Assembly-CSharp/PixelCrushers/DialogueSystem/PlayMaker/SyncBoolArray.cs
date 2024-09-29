using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncBoolArray : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmArray playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
