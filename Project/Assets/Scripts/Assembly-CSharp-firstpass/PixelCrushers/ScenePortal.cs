using UnityEngine;

namespace PixelCrushers
{
	public class ScenePortal : MonoBehaviour
	{
		[SerializeField]
		private string m_requiredTag;
		[SerializeField]
		private string m_destinationSceneName;
		[SerializeField]
		private string m_spawnpointNameInDestinationScene;
	}
}
