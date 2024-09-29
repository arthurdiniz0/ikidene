using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	public class SetEmissionRate : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat emissionRate;
	}
}
