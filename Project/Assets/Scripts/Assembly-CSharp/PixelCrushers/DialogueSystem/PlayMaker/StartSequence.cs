using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class StartSequence : FsmStateAction
	{
		public FsmString sequence;
		public FsmGameObject speaker;
		public FsmGameObject listener;
		public FsmBool informParticipants;
		public FsmObject storeResult;
	}
}
