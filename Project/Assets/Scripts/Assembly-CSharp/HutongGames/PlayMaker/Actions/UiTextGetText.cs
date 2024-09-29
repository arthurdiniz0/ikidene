using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiTextGetText : ComponentAction<Text>
	{
		public FsmOwnerDefault gameObject;
		public FsmString text;
		public bool everyFrame;
	}
}
