using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiImageSetFillAmount : ComponentAction<Image>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat ImageFillAmount;
		public bool everyFrame;
	}
}
