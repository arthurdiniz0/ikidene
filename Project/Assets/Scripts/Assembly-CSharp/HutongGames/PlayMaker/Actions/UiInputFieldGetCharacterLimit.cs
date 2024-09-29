using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiInputFieldGetCharacterLimit : ComponentAction<InputField>
	{
		public FsmOwnerDefault gameObject;
		public FsmInt characterLimit;
		public FsmEvent hasNoLimitEvent;
		public FsmEvent isLimitedEvent;
		public bool everyFrame;
	}
}
