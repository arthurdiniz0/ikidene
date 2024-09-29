using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	public class Simulate : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat time;
	}
}
