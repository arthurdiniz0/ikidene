using UnityEngine;

namespace Cinemachine
{
	public class CinemachineStoryboard : CinemachineExtension
	{
		public enum FillStrategy
		{
			BestFit = 0,
			CropImageToFit = 1,
			StretchToFit = 2,
		}

		public bool m_ShowImage;
		public Texture m_Image;
		public FillStrategy m_Aspect;
		public float m_Alpha;
		public Vector2 m_Center;
		public Vector3 m_Rotation;
		public Vector2 m_Scale;
		public bool m_SyncScale;
		public bool m_MuteCamera;
		public float m_SplitView;
	}
}
