using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SetQuestEntryState : FsmStateAction
	{
		public FsmString questName;
		public FsmInt entryNumber;
		public FsmString state;
	}
}
