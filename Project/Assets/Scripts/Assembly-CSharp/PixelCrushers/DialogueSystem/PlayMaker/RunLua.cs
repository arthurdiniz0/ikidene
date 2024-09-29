using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class RunLua : FsmStateAction
	{
		public FsmString luaCode;
		public FsmBool debug;
		public FsmVar storeResult;
	}
}
