using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class RectTransformScreenPointToWorldPointInRectangle : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmVector2 screenPointVector2;
		public FsmVector3 orScreenPointVector3;
		public bool normalizedScreenPoint;
		public FsmGameObject camera;
		public bool everyFrame;
		public FsmVector3 worldPosition;
		public FsmBool isHit;
		public FsmEvent hitEvent;
		public FsmEvent noHitEvent;
	}
}
