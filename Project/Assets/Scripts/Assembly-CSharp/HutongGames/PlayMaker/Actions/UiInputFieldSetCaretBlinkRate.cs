using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldSetCaretBlinkRate : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmInt caretBlinkRate;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
