using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCorn : MonoBehaviour
{
    public static int chosenCorn = -1;
    public static int chosenCornLocation = -1;
    public Texture notChosenToggle;
    public Texture chosenToggle;

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
        RawImage[] toggles;
        if (chosenCornLocation != -1) {
            GameObject cornGrid = GameObject.Find("CornGrid" + chosenCornLocation);
            toggles = cornGrid.GetComponentsInChildren<RawImage>();
            if (toggles.Length > 0 && toggles[1].texture.Equals(chosenToggle)) {
                toggles[1].texture = notChosenToggle;
            }
        }
        chosenCornLocation = int.Parse((string)name.Substring(8));
        Debug.Log("Choose " + OpenFood.availableCorns[chosenCornLocation]);
        chosenCorn = OpenFood.availableCorns[chosenCornLocation];
        toggles = GetComponentsInChildren<RawImage>();
        if (toggles.Length > 0) {
            toggles[1].texture = chosenToggle;
        }
    }
}
