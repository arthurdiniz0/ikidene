using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSliderOnValueChangedEvent : ComponentAction<Slider>
	{
		public FsmOwnerDefault gameObject;
		public FsmEventTarget eventTarget;
		public FsmEvent sendEvent;
		public FsmFloat value;
	}
}
