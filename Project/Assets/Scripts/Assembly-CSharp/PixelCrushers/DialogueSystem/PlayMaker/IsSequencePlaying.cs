using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class IsSequencePlaying : FsmStateAction
	{
		public FsmObject sequencerHandle;
		public FsmBool storeResult;
		public FsmBool everyFrame;
		public FsmEvent playingEvent;
		public FsmEvent notPlayingEvent;
	}
}
