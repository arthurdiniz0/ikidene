using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetMinDistance : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat minDistance;
	}
}
