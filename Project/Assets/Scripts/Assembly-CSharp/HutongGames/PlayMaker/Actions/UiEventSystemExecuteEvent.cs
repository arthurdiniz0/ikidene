using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiEventSystemExecuteEvent : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmEnum eventHandler;
		public FsmEvent success;
		public FsmEvent canNotHandleEvent;
	}
}
