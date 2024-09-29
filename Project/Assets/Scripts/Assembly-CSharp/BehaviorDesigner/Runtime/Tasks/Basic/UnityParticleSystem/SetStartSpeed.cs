using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	public class SetStartSpeed : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat startSpeed;
	}
}
