using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class TriggerEvent : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public TriggerType trigger;
		public FsmString collideTag;
		public FsmEvent sendEvent;
		public FsmGameObject storeCollider;
	}
}
