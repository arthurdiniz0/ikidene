using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiGraphicSetColor : ComponentAction<Graphic>
	{
		public FsmOwnerDefault gameObject;
		public FsmColor color;
		public FsmFloat red;
		public FsmFloat green;
		public FsmFloat blue;
		public FsmFloat alpha;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
