namespace PixelCrushers.DialogueSystem
{
	public enum DialogueTriggerEvent
	{
		OnBarkEnd = 1,
		OnConversationEnd = 2,
		OnSequenceEnd = 4,
		OnTriggerEnter = 8,
		OnStart = 16,
		OnUse = 32,
		OnEnable = 64,
		OnTriggerExit = 128,
		OnDisable = 256,
		OnDestroy = 512,
		None = 1024,
		OnCollisionEnter = 2048,
		OnCollisionExit = 4096,
	}
}
