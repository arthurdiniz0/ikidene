using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class LoadSceneAsynch : FsmStateAction
	{
		public GetSceneActionBase.SceneSimpleReferenceOptions sceneReference;
		public FsmString sceneByName;
		public FsmInt sceneAtIndex;
		public FsmEnum loadSceneMode;
		public FsmBool allowSceneActivation;
		public FsmInt operationPriority;
		public FsmInt aSyncOperationHashCode;
		public FsmFloat progress;
		public FsmBool isDone;
		public FsmBool pendingActivation;
		public FsmEvent doneEvent;
		public FsmEvent pendingActivationEvent;
		public FsmEvent sceneNotFoundEvent;
	}
}
