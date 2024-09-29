using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	public class SharedVariable<T> : SharedVariable
	{
		[SerializeField]
		protected T mValue;
	}
}
