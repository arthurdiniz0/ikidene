using UnityEngine;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiCanvasGroupSetAlpha : ComponentAction<CanvasGroup>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat alpha;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
