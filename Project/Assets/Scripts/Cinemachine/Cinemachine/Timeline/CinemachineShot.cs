using UnityEngine.Playables;
using UnityEngine;
using Cinemachine;

namespace Cinemachine.Timeline
{
	public class CinemachineShot : PlayableAsset
	{
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera;
	}
}
