using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetText : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmString text;
		public bool everyFrame;
	}
}
