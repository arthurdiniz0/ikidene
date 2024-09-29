using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldDeactivate : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool activateOnExit;
	}
}
