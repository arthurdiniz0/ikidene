using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncString : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmString playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
