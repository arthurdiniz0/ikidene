using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSliderSetMinMax : ComponentAction<Slider>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat minValue;
		public FsmFloat maxValue;
		public FsmBool resetOnExit;
		public bool everyFrame;
	}
}
