using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class RectTransformWorldToScreenPoint : BaseUpdateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmOwnerDefault camera;
		public FsmVector3 screenPoint;
		public FsmFloat screenX;
		public FsmFloat screenY;
		public FsmBool normalize;
	}
}
