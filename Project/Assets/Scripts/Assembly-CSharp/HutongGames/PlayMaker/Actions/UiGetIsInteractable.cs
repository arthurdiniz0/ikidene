using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiGetIsInteractable : ComponentAction<Selectable>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool isInteractable;
		public FsmEvent isInteractableEvent;
		public FsmEvent isNotInteractableEvent;
	}
}
