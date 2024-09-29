using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiCanvasScalerGetScaleFactor : ComponentAction<CanvasScaler>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat scaleFactor;
		public bool everyFrame;
	}
}
