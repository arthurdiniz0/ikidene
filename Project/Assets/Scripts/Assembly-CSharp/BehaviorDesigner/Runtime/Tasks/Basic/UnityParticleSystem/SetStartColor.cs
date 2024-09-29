using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	public class SetStartColor : Action
	{
		public SharedGameObject targetGameObject;
		public SharedColor startColor;
	}
}
