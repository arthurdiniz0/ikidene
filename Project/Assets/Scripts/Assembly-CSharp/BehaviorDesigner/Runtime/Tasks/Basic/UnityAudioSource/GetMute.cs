using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class GetMute : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool storeValue;
	}
}
