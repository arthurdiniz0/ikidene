using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class ArrayGetRandom : FsmStateAction
	{
		public FsmArray array;
		public FsmVar storeValue;
		public FsmInt index;
		public FsmBool noRepeat;
		public bool everyFrame;
	}
}
