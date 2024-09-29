using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiTextSetText : ComponentAction<Text>
	{
		public FsmOwnerDefault gameObject;
		public FsmString text;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
