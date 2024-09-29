using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiRawImageSetTexture : ComponentAction<RawImage>
	{
		public FsmOwnerDefault gameObject;
		public FsmTexture texture;
		public FsmBool resetOnExit;
	}
}
