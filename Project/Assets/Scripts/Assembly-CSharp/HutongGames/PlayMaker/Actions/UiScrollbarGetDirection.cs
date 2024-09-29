using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiScrollbarGetDirection : ComponentAction<Scrollbar>
	{
		public FsmOwnerDefault gameObject;
		public FsmEnum direction;
		public bool everyFrame;
	}
}
