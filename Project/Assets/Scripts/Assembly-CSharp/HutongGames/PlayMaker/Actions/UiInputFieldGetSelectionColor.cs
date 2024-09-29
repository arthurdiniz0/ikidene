using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetSelectionColor : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmColor selectionColor;
		public bool everyFrame;
	}
}
