using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Trigger2dEvent : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public Trigger2DType trigger;
		public FsmString collideTag;
		public FsmEvent sendEvent;
		public FsmGameObject storeCollider;
	}
}
