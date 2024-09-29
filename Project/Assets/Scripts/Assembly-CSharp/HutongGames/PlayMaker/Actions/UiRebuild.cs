using UnityEngine.UI;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiRebuild : ComponentAction<Graphic>
	{
		public FsmOwnerDefault gameObject;
		public CanvasUpdate canvasUpdate;
		public bool rebuildOnExit;
	}
}
