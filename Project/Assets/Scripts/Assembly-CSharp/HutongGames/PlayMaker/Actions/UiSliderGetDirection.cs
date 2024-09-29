using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiSliderGetDirection : ComponentAction<Slider>
	{
		public FsmOwnerDefault gameObject;
		public FsmEnum direction;
		public bool everyFrame;
	}
}
