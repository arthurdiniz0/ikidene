using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class Vector2Add : FsmStateAction
	{
		public FsmVector2 vector2Variable;
		public FsmVector2 addVector;
		public bool everyFrame;
		public bool perSecond;
	}
}
