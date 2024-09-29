using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class Translate : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 translation;
		public Space relativeTo;
	}
}
