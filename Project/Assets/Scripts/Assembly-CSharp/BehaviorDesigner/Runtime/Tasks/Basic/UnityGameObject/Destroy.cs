using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class Destroy : Action
	{
		public SharedGameObject targetGameObject;
		public float time;
	}
}
