using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSliderGetValue : ComponentAction<Slider>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat value;
		public bool everyFrame;
	}
}
