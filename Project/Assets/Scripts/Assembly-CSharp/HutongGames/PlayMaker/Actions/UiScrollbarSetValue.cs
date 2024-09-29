using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiScrollbarSetValue : ComponentAction<Scrollbar>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat value;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
