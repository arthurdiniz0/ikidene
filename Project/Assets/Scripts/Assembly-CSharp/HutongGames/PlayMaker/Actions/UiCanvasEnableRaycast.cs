using HutongGames.PlayMaker;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	public class UiCanvasEnableRaycast : ComponentAction<PlayMakerCanvasRaycastFilterProxy>
	{
		public FsmOwnerDefault gameObject;
		public FsmBool enableRaycasting;
		public FsmBool resetOnExit;
		public bool everyFrame;
		[SerializeField]
		private PlayMakerCanvasRaycastFilterProxy raycastFilterProxy;
	}
}
