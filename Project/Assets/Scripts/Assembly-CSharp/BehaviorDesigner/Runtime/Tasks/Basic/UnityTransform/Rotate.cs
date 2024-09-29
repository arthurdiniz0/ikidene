using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class Rotate : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 eulerAngles;
		public Space relativeTo;
	}
}
