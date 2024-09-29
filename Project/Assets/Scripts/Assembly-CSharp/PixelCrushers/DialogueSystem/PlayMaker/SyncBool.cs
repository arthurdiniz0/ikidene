using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncBool : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmBool playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
