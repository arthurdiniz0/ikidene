using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiDropDownSetValue : ComponentAction<Dropdown>
	{
		public FsmOwnerDefault gameObject;
		public FsmInt value;
		public bool everyFrame;
	}
}
