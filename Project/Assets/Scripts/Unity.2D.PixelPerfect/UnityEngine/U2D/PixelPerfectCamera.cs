using UnityEngine;

namespace UnityEngine.U2D
{
	public class PixelPerfectCamera : MonoBehaviour
	{
		[SerializeField]
		private int m_AssetsPPU;
		[SerializeField]
		private int m_RefResolutionX;
		[SerializeField]
		private int m_RefResolutionY;
		[SerializeField]
		private bool m_UpscaleRT;
		[SerializeField]
		private bool m_PixelSnapping;
		[SerializeField]
		private bool m_CropFrameX;
		[SerializeField]
		private bool m_CropFrameY;
		[SerializeField]
		private bool m_StretchFill;
	}
}
