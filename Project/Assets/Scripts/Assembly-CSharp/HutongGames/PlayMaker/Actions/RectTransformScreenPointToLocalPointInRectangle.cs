using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class RectTransformScreenPointToLocalPointInRectangle : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmVector2 screenPointVector2;
		public FsmVector3 orScreenPointVector3;
		public bool normalizedScreenPoint;
		public FsmGameObject camera;
		public bool everyFrame;
		public FsmVector3 localPosition;
		public FsmVector2 localPosition2d;
		public FsmBool isHit;
		public FsmEvent hitEvent;
		public FsmEvent noHitEvent;
	}
}
