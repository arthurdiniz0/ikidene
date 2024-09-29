using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class SetVariable : FsmStateAction
	{
		public FsmString variableName;
		public FsmString stringValue;
		public FsmFloat floatValue;
		public FsmInt intValue;
		public FsmBool boolValue;
	}
}
