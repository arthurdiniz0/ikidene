using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiTransitionSetType : ComponentAction<Selectable>
	{
		public FsmOwnerDefault gameObject;
		public Selectable.Transition transition;
		public FsmBool resetOnExit;
	}
}
