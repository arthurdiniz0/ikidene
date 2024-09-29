using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldOnSubmitEvent : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmEventTarget eventTarget;
		public FsmEvent sendEvent;
		public FsmString text;
	}
}
