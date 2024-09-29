using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiNavigationSetMode : ComponentAction<Selectable>
	{
		public FsmOwnerDefault gameObject;
		public Navigation.Mode navigationMode;
		public FsmBool resetOnExit;
	}
}
