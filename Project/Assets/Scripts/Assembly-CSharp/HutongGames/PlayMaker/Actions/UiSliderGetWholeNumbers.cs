using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSliderGetWholeNumbers : ComponentAction<Slider>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool wholeNumbers;
		public FsmEvent isShowingWholeNumbersEvent;
		public FsmEvent isNotShowingWholeNumbersEvent;
	}
}
