using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace RealTimeFaceRecognitionExample
{
    public class RealTimeFaceRecognitionNaming : MonoBehaviour
    {

        public GameObject textfieldAsset;
        GameObject[] textFields;
        public GameObject canvas;

        int nPersons;

        // Use this for initialization
        void Start()
        {
            nPersons = GameManager.instance.numberOfPersons;
            textFields = new GameObject[nPersons];
            for (int i = 0; i < nPersons; i++)
            {
                GameObject txt = Instantiate(textfieldAsset);
                txt.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Personne N° " + (i+1);
                txt.transform.SetParent(canvas.GetComponent<LayoutGroup>().transform, false);
                textFields[i] = txt;
            }
        }

        public void OnWebCamTextureRealTimeFaceRecognitionAcceptNamingButtonClick()
        {
            for (int i = 0; i < nPersons; i++)
                GameManager.instance.personsNames.Add(textFields[i].GetComponent<InputField>().text);

            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
                SceneManager.LoadScene("FaceRecognitionFinalScene");
            #else
			Application.LoadLevel ("FaceRecognitionFinalScene");
            #endif
        }
    }
}
