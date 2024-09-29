using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetTextAsInt : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmInt value;
		public FsmBool isInt;
		public FsmEvent isIntEvent;
		public FsmEvent isNotIntEvent;
		public bool everyFrame;
	}
}
