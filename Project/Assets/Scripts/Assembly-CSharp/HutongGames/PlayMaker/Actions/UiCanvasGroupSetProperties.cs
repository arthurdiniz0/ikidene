using UnityEngine;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiCanvasGroupSetProperties : ComponentAction<CanvasGroup>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat alpha;
		public FsmBool interactable;
		public FsmBool blocksRaycasts;
		public FsmBool ignoreParentGroup;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
