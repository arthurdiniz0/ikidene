using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Action
{
	public class ObjectDirection : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmGameObject toGameObject;
		public FsmVector3 storeResult;
	}
}
