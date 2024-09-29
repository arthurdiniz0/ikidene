using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class GetLuaField : FsmStateAction
	{
		public LuaTableEnum table;
		public FsmString element;
		public FsmString field;
		public FsmBool getLocalizedVersion;
		public FsmString storeStringResult;
		public FsmFloat storeFloatResult;
		public FsmInt storeIntResult;
		public FsmBool storeBoolResult;
		public bool everyFrame;
	}
}
