using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiImageSetSprite : ComponentAction<Image>
	{
		public FsmOwnerDefault gameObject;
		public FsmObject sprite;
		public FsmBool resetOnExit;
	}
}
