using UnityEngine;

namespace PixelCrushers
{
	public class DataSynchronizer : MonoBehaviour
	{
		[SerializeField]
		private string m_dataSourceName;
		[SerializeField]
		private ObjectUnityEvent m_onRequestDataSourceChangeValue;
	}
}
