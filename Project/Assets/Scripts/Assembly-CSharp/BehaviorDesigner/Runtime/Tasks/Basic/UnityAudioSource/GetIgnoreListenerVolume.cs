using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class GetIgnoreListenerVolume : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool storeValue;
	}
}
