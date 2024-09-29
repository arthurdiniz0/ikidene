using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiScrollRectSetHorizontal : ComponentAction<ScrollRect>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool horizontal;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
