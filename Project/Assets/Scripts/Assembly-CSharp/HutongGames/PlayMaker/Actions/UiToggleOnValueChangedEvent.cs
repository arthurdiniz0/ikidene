using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiToggleOnValueChangedEvent : ComponentAction<Toggle>
	{
		public FsmOwnerDefault gameObject;
		public FsmEventTarget eventTarget;
		public FsmEvent sendEvent;
		public FsmBool value;
	}
}
