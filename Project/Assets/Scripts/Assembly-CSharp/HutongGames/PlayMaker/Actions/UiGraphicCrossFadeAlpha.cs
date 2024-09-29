using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiGraphicCrossFadeAlpha : ComponentAction<Graphic>
	{
		public FsmOwnerDefault gameObject;
		public FsmFloat alpha;
		public FsmFloat duration;
		public FsmBool ignoreTimeScale;
	}
}
