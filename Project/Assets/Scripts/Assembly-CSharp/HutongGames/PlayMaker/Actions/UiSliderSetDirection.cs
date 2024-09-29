using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSliderSetDirection : ComponentAction<Slider>
	{
		public FsmOwnerDefault gameObject;
		public FsmEnum direction;
		public FsmBool includeRectLayouts;
		public FsmBool resetOnExit;
	}
}
