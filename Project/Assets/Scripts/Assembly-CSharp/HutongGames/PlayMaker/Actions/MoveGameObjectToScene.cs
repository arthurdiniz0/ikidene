using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class MoveGameObjectToScene : GetSceneActionBase
	{
		public FsmOwnerDefault gameObject;
		public FsmBool findRootIfNecessary;
		public FsmBool success;
		public FsmEvent successEvent;
		public FsmEvent failureEvent;
	}
}
