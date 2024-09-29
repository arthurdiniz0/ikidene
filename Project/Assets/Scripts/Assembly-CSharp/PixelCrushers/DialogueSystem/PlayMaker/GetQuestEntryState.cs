using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class GetQuestEntryState : FsmStateAction
	{
		public FsmString questName;
		public FsmInt entryNumber;
		public FsmString storeResult;
		public FsmEvent unassignedStateEvent;
		public FsmEvent activeStateEvent;
		public FsmEvent successStateEvent;
		public FsmEvent failureStateEvent;
	}
}
