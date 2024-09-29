using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldSetPlaceHolder : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmGameObject placeholder;
		public FsmBool resetOnExit;
	}
}
