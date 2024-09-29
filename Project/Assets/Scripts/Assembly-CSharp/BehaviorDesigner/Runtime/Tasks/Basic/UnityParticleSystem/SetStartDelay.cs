using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	public class SetStartDelay : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat startDelay;
	}
}
