using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCorn : MonoBehaviour
{
    public static int chosenCorn = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && RectTransformUtility.RectangleContainsScreenPoint(GetComponent<RectTransform>(), Input.mousePosition)) {
            Change();
        }
    }

    void Change()
    {
        Debug.Log("Choose " + OpenFood.availableCorns[int.Parse((string)name.Substring(8))]);
        chosenCorn = OpenFood.availableCorns[int.Parse((string)name.Substring(8))];
    }
}
