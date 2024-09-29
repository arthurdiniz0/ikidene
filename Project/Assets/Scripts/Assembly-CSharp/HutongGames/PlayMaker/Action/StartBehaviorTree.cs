using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Action
{
	public class StartBehaviorTree : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmInt group;
		public FsmBool waitForCompletion;
		public FsmBool synchronizeVariables;
		public FsmBool synchronizeGlobalVariables;
		public FsmBool storeSuccess;
	}
}
