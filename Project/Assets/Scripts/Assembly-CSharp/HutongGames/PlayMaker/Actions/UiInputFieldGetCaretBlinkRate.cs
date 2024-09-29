using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetCaretBlinkRate : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat caretBlinkRate;
		public bool everyFrame;
	}
}
