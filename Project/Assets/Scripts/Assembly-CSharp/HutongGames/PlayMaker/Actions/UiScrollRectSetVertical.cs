using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiScrollRectSetVertical : ComponentAction<ScrollRect>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool vertical;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
