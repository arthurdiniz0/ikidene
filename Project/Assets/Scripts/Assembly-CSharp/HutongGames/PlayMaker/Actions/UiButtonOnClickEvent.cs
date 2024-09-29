using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiButtonOnClickEvent : ComponentAction<Button>
	{
		public FsmOwnerDefault gameObject;
		public FsmEventTarget eventTarget;
		public FsmEvent sendEvent;
	}
}
