using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class CompareTag : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedString tag;
	}
}
