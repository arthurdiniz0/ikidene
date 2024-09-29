using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetHideMobileInput : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool hideMobileInput;
		public FsmEvent mobileInputHiddenEvent;
		public FsmEvent mobileInputShownEvent;
	}
}
