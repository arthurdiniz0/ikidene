using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiDropDownAddOptions : ComponentAction<Dropdown>
	{
		public FsmOwnerDefault gameObject;
		public FsmString[] optionText;
		public FsmObject[] optionImage;
	}
}
