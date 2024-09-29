using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class StartConversation : FsmStateAction
	{
		public FsmString conversation;
		public FsmInt startingEntryID;
		public FsmGameObject actor;
		public FsmGameObject conversant;
	}
}
