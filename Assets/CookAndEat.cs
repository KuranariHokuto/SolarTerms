using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookAndEat : MonoBehaviour
{
    public GameObject bookChosen;
    public GameObject phoneChosen;

    // Start is called before the first frame update
    void Start()
    {
        bookChosen.SetActive(false);
        phoneChosen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
