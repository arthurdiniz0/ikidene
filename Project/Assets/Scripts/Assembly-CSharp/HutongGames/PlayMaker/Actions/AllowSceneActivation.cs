using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class AllowSceneActivation : FsmStateAction
	{
		public FsmInt aSynchOperationHashCode;
		public FsmBool allowSceneActivation;
		public FsmFloat progress;
		public FsmBool isDone;
		public FsmEvent doneEvent;
		public FsmEvent failureEvent;
	}
}
