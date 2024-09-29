using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldOnEndEditEvent : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmEventTarget eventTarget;
		public FsmEvent sendEvent;
		public FsmString text;
		public FsmBool wasCanceled;
	}
}
