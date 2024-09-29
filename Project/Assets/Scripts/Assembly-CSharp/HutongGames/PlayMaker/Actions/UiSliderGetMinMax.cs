using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSliderGetMinMax : ComponentAction<Slider>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat minValue;
		public FsmFloat maxValue;
	}
}
