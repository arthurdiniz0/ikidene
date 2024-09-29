using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Action
{
	public class SendEvent : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmInt group;
		public FsmString eventName;
	}
}
