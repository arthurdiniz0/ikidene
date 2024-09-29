using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldSetText : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmString text;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
