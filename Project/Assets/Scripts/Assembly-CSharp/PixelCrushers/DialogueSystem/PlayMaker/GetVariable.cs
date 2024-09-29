using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class GetVariable : FsmStateAction
	{
		public FsmString variableName;
		public FsmString storeStringResult;
		public FsmFloat storeFloatResult;
		public FsmInt storeIntResult;
		public FsmBool storeBoolResult;
		public bool everyFrame;
	}
}
