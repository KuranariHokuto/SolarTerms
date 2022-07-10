using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBook : MonoBehaviour
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
        bookChosen.SetActive(true);
        phoneChosen.SetActive(false);
        Invoke("EatOnBook", 0.5f);
    }

    public void EatOnBook()
    {
        Debug.Log("EatOnBook");
    }
}
