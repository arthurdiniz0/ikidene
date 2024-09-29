using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiDropDownGetSelectedData : ComponentAction<Dropdown>
	{
		public FsmOwnerDefault gameObject;
		public FsmInt index;
		public FsmString getText;
		public FsmObject getImage;
		public bool everyFrame;
	}
}
