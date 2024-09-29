using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class LoadScene : FsmStateAction
	{
		public GetSceneActionBase.SceneSimpleReferenceOptions sceneReference;
		public FsmString sceneByName;
		public FsmInt sceneAtIndex;
		public FsmEnum loadSceneMode;
		public FsmBool success;
		public FsmEvent successEvent;
		public FsmEvent failureEvent;
	}
}
