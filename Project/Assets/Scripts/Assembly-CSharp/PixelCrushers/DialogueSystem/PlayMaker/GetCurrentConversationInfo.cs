using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class GetCurrentConversationInfo : FsmStateAction
	{
		public FsmString conversationTitle;
		public FsmInt conversationID;
		public FsmInt entryID;
		public FsmString actorName;
		public FsmString conversantName;
	}
}
