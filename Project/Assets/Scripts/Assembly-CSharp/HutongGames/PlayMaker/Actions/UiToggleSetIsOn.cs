using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiToggleSetIsOn : ComponentAction<Toggle>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool isOn;
		public FsmBool resetOnExit;
	}
}
