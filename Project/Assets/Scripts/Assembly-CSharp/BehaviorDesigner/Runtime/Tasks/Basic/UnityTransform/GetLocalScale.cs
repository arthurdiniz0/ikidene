using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class GetLocalScale : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 storeValue;
	}
}
