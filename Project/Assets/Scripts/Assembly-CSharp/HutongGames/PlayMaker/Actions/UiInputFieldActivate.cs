using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldActivate : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool deactivateOnExit;
	}
}
