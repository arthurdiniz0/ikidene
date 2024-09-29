using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetLoop : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool loop;
	}
}
