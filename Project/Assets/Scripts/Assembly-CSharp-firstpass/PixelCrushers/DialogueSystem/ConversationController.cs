namespace PixelCrushers.DialogueSystem
{
	public class ConversationController
	{
		public delegate void EndConversationDelegate(ConversationController ConversationController);

		public ConversationController(ConversationModel model, ConversationView view, bool alwaysForceResponseMenu, ConversationController.EndConversationDelegate endConversationHandler)
		{
		}

	}
}
