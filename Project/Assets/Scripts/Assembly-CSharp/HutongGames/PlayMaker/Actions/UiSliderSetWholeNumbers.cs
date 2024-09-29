using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSliderSetWholeNumbers : ComponentAction<Slider>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool wholeNumbers;
		public FsmBool resetOnExit;
	}
}
