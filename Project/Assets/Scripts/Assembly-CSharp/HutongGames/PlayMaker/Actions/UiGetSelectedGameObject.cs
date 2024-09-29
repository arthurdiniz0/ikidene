using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiGetSelectedGameObject : FsmStateAction
	{
		public FsmGameObject StoreGameObject;
		public FsmEvent ObjectChangedEvent;
		public bool everyFrame;
	}
}
