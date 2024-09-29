using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetTextAsFloat : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat value;
		public FsmBool isFloat;
		public FsmEvent isFloatEvent;
		public FsmEvent isNotFloatEvent;
		public bool everyFrame;
	}
}
