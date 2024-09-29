using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldSetAsterixChar : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmString asterixChar;
		public FsmBool resetOnExit;
	}
}
