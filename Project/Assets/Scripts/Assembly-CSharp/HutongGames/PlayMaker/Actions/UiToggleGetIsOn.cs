using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiToggleGetIsOn : ComponentAction<Toggle>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool value;
		public FsmEvent isOnEvent;
		public FsmEvent isOffEvent;
		public bool everyFrame;
	}
}
