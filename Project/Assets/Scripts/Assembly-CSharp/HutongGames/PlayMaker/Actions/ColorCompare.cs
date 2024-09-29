using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class ColorCompare : FsmStateAction
	{
		public FsmColor color1;
		public FsmColor color2;
		public FsmFloat tolerance;
		public FsmEvent equal;
		public FsmEvent notEqual;
		public bool everyFrame;
	}
}
