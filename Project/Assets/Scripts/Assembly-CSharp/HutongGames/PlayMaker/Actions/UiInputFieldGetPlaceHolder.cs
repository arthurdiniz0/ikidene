using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetPlaceHolder : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmGameObject placeHolder;
		public FsmBool placeHolderDefined;
		public FsmEvent foundEvent;
		public FsmEvent notFoundEvent;
	}
}
