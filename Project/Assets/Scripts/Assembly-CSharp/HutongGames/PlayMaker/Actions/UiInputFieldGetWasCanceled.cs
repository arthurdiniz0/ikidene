using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetWasCanceled : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool wasCanceled;
		public FsmEvent wasCanceledEvent;
		public FsmEvent wasNotCanceledEvent;
	}
}
