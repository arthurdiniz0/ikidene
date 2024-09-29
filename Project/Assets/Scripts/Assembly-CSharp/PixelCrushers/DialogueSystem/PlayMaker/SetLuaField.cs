using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SetLuaField : FsmStateAction
	{
		public LuaTableEnum table;
		public FsmString element;
		public FsmString field;
		public FsmString stringValue;
		public FsmFloat floatValue;
		public FsmInt intValue;
		public FsmBool boolValue;
	}
}
