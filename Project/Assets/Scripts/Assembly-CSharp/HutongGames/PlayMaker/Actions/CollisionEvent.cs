using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class CollisionEvent : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public CollisionType collision;
		public FsmString collideTag;
		public FsmEvent sendEvent;
		public FsmGameObject storeCollider;
		public FsmFloat storeForce;
	}
}
