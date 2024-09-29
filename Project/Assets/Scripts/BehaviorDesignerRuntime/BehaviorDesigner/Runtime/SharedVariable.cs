using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	public class SharedVariable
	{
		[SerializeField]
		private bool mIsShared;
		[SerializeField]
		private bool mIsGlobal;
		[SerializeField]
		private string mName;
		[SerializeField]
		private string mPropertyMapping;
		[SerializeField]
		private GameObject mPropertyMappingOwner;
		[SerializeField]
		private bool mNetworkSync;
	}
}
