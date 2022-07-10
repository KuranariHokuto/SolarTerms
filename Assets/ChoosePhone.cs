using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePhone : MonoBehaviour
{
    public GameObject bookChosen;
    public GameObject phoneChosen;

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
        bookChosen.SetActive(false);
        phoneChosen.SetActive(true);
        Invoke("EatOnPhone", 0.5f);
    }

    public void EatOnPhone()
    {
        Debug.Log("EatOnPhone");
    }
}
