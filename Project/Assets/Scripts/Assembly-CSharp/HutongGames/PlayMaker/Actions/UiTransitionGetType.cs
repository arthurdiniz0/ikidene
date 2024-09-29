using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiTransitionGetType : ComponentAction<Selectable>
	{
		public FsmOwnerDefault gameObject;
		public FsmString transition;
		public FsmEvent colorTintEvent;
		public FsmEvent spriteSwapEvent;
		public FsmEvent animationEvent;
		public FsmEvent noTransitionEvent;
	}
}
