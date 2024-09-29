using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncStringArray : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmArray playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
