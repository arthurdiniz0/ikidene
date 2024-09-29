using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiGraphicGetColor : ComponentAction<Graphic>
	{
		public FsmOwnerDefault gameObject;
		public FsmColor color;
		public bool everyFrame;
	}
}
