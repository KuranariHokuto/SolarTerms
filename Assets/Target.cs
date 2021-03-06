using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public string solarTerm;

    // Start is called before the first frame update
    void Start()
    {
        if (string.IsNullOrEmpty(solarTerm)) {
            solarTerm = name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && Input.GetAxis("Mouse X") == 0 && Input.GetAxis("Mouse Y") == 0
        && RectTransformUtility.RectangleContainsScreenPoint(GetComponent<RectTransform>(), Input.mousePosition)) {
            Debug.Log("========================InputTarget" + solarTerm);
            StartCoroutine(LoadScene(solarTerm + "Scene"));
        }
    }

    public void AutoTarget() {
        Debug.Log("========================AutoTarget" + solarTerm);
        StartCoroutine(LoadScene(solarTerm + "Scene"));
    }

    IEnumerator LoadScene(string sceneName)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
