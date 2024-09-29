using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class AbstractTypewriterEffect : MonoBehaviour
	{
		public bool rightToLeft;
		public float charactersPerSecond;
		public AudioClip audioClip;
		public AudioClip[] alternateAudioClips;
		public AudioSource audioSource;
		public bool interruptAudioClip;
		public string silentCharacters;
		public string fullPauseCharacters;
		public string quarterPauseCharacters;
		public float fullPauseDuration;
		public float quarterPauseDuration;
		public bool removeDuplicateTypewriterEffects;
		public bool playOnEnable;
		public bool waitOneFrameBeforeStarting;
		public bool stopOnConversationEnd;
	}
}
