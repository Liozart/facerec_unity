using UnityEngine;
using System.Collections;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace RealTimeFaceRecognitionExample
{
    public class RealTimeFaceRecognitionInfos2 : MonoBehaviour
    {

        public void OnWebCamTextureRealTimeFaceRecognitionInfos2ButtonClick()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
			SceneManager.LoadScene("FaceRecognitionNamingScene");
            #else
			Application.LoadLevel ("FaceRecognitionNamingScene");
            #endif  
        }
    }
}
