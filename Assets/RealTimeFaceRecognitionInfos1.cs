using UnityEngine;
using System.Collections;
using UnityEngine.UI;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace RealTimeFaceRecognitionExample
{
	public class RealTimeFaceRecognitionInfos1 : MonoBehaviour
	{
		public void OnWebCamTextureRealTimeFaceRecognitionInfos1ButtonClick ()
		{
			#if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene ("FaceRecognitionFaceHarvestScene");
			#else
			Application.LoadLevel ("FaceRecognitionFaceHarvestScene");
			#endif
		}
	}
}
