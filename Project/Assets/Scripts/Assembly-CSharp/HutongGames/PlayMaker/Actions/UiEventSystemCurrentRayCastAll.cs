using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class UiEventSystemCurrentRayCastAll : FsmStateAction
	{
		public FsmVector3 screenPosition;
		public FsmVector2 orScreenPosition2d;
		public FsmArray gameObjectList;
		public FsmInt hitCount;
		public bool everyFrame;
	}
}
