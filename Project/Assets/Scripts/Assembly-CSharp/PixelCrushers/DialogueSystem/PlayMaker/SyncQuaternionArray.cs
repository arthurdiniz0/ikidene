using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncQuaternionArray : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmArray playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
