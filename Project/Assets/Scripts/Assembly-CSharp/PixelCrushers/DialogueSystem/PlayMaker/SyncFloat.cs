using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SyncFloat : FsmStateAction
	{
		public FsmString dialogueSystemVariable;
		public FsmFloat playMakerVariable;
		public FsmBool toDialogueSystem;
		public bool everyFrame;
	}
}
