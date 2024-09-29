using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetMute : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool mute;
	}
}
