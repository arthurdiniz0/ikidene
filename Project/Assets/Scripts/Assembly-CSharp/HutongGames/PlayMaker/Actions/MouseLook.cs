using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class MouseLook : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public MouseLook.RotationAxes axes;
		public FsmFloat sensitivityX;
		public FsmFloat sensitivityY;
		public FsmFloat minimumX;
		public FsmFloat maximumX;
		public FsmFloat minimumY;
		public FsmFloat maximumY;
		public bool everyFrame;
	}
}
