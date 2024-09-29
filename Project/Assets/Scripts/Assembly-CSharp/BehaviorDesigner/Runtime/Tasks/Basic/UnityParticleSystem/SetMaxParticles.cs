using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	public class SetMaxParticles : Action
	{
		public SharedGameObject targetGameObject;
		public SharedInt maxParticles;
	}
}
