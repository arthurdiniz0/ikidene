using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class DoesConversationHaveValidEntries : FsmStateAction
	{
		public FsmString conversation;
		public FsmGameObject actor;
		public FsmGameObject conversant;
		public FsmBool storeResult;
		public FsmEvent validEvent;
		public FsmEvent notValidEvent;
	}
}
