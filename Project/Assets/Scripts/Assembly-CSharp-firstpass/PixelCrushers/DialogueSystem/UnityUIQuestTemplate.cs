using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIQuestTemplate : MonoBehaviour
	{
		public Button heading;
		public Text description;
		public UnityUIQuestTemplateAlternateDescriptions alternateDescriptions;
		public Transform entryContainer;
		public Text entryDescription;
		public UnityUIQuestTemplateAlternateDescriptions alternateEntryDescriptions;
		public Button trackButton;
		public Button abandonButton;
	}
}
