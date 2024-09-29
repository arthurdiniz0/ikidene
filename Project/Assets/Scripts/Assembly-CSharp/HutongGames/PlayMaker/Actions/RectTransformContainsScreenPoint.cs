using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class RectTransformContainsScreenPoint : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmVector2 screenPointVector2;
		public FsmVector3 orScreenPointVector3;
		public bool normalizedScreenPoint;
		public FsmGameObject camera;
		public bool everyFrame;
		public FsmBool isContained;
		public FsmEvent isContainedEvent;
		public FsmEvent isNotContainedEvent;
	}
}
