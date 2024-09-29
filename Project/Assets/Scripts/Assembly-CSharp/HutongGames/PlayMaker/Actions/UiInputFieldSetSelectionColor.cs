using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldSetSelectionColor : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmColor selectionColor;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
