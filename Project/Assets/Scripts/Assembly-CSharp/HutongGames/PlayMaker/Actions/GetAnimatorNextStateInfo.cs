using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class GetAnimatorNextStateInfo : FsmStateActionAnimatorBase
	{
		public FsmOwnerDefault gameObject;
		public FsmInt layerIndex;
		public new FsmString name;
		public FsmInt nameHash;
		public FsmInt fullPathHash;
		public FsmInt shortPathHash;
		public FsmInt tagHash;
		public FsmBool isStateLooping;
		public FsmFloat length;
		public FsmFloat normalizedTime;
		public FsmInt loopCount;
		public FsmFloat currentLoopProgress;
	}
}
