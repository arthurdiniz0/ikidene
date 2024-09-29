using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncVector3 : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmVector3 playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
