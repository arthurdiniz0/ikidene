using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetPriority : Action
	{
		public SharedGameObject targetGameObject;
		public SharedInt priority;
	}
}
