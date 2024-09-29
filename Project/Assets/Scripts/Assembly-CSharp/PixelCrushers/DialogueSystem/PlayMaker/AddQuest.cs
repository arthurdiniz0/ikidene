using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class AddQuest : FsmStateAction
	{
		public FsmString questName;
		public FsmString description;
		public FsmString successDescription;
		public FsmString failureDescription;
		public FsmString state;
	}
}
