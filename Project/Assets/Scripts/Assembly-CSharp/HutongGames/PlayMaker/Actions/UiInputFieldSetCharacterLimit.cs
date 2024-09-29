using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldSetCharacterLimit : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmInt characterLimit;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
