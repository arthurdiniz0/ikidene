using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	public class SetStartLifetime : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat startLifetime;
	}
}
