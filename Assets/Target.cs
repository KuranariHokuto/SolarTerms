using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Target : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TargetLichun()
    {
        Debug.Log("========================TargetLichun");
        SceneManager.LoadScene("LichunScene", LoadSceneMode.Single);
    }

}
