namespace PixelCrushers.DialogueSystem
{
	public class LuaTrigger : DialogueEventStarter
	{
		public DialogueTriggerEvent trigger;
		public Condition condition;
		public string luaCode;
	}
}
