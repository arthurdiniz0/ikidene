using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSetAnimationTriggers : ComponentAction<Selectable>
	{
		public FsmOwnerDefault gameObject;
		public FsmString normalTrigger;
		public FsmString highlightedTrigger;
		public FsmString pressedTrigger;
		public FsmString disabledTrigger;
		public FsmBool resetOnExit;
	}
}
