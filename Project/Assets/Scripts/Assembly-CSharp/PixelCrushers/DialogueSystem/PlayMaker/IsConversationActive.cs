using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class IsConversationActive : FsmStateAction
	{
		public FsmBool everyFrame;
		public FsmBool storeResult;
		public FsmEvent activeEvent;
		public FsmEvent inactiveEvent;
	}
}
