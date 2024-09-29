namespace PixelCrushers.DialogueSystem
{
	public class AlertTrigger : DialogueEventStarter
	{
		public DialogueTriggerEvent trigger;
		public LocalizedTextTable localizedTextTable;
		public string message;
		public float duration;
		public Condition condition;
	}
}
