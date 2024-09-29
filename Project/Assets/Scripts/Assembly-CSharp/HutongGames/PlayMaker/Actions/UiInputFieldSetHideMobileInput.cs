using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldSetHideMobileInput : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool hideMobileInput;
		public FsmBool resetOnExit;
	}
}
