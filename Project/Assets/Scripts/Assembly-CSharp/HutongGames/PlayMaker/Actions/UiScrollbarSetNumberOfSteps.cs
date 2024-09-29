using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiScrollbarSetNumberOfSteps : ComponentAction<Scrollbar>
	{
		public FsmOwnerDefault gameObject;
		public FsmInt value;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
