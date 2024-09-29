using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class PlayOneShot : Action
	{
		public SharedGameObject targetGameObject;
		public SharedObject clip;
		public SharedFloat volumeScale;
	}
}
