using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	public class SetEnableEmission : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool enable;
	}
}
