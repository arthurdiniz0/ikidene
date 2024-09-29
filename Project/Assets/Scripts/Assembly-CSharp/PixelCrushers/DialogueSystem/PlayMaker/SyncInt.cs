using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncInt : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmInt playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
