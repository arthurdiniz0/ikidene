using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetIsFocused : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool isFocused;
		public FsmEvent isfocusedEvent;
		public FsmEvent isNotFocusedEvent;
	}
}
