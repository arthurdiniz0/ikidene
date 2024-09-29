using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiScrollRectSetNormalizedPosition : ComponentAction<ScrollRect>
	{
		public FsmOwnerDefault gameObject;
		public FsmVector2 normalizedPosition;
		public FsmFloat horizontalPosition;
		public FsmFloat verticalPosition;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
