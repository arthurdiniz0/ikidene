using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAudioSource
{
	public class SetPitch : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat pitch;
	}
}
