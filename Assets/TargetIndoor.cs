using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetIndoor : MonoBehaviour
{
    public GameObject promptCanvas1;
    public GameObject cookEatCanvas;
    public GameObject cook;
    public GameObject eatCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Targeted()
    {
        promptCanvas1.SetActive(false);
        cookEatCanvas.SetActive(true);
        cook.SetActive(true);
        eatCanvas.SetActive(false);
        Invoke("Eat", 3);
    }

    public void Eat()
    {
        cook.SetActive(false);
        eatCanvas.SetActive(true);
        foreach (Transform food in eatCanvas.transform)
        {
            if (ChooseFruit.chosenFruits.Contains(int.Parse(food.name))
                || ChooseVegetable.chosenVegetables.Contains(int.Parse(food.name))
                || ChooseMeat.chosenMeats.Contains(int.Parse(food.name))
                || ChooseCorn.chosenCorns.Contains(int.Parse(food.name))) {
                food.gameObject.SetActive(true);
            } else {
                food.gameObject.SetActive(false);
            }
        }
    }

    public void TargetLost()
    {
        cookEatCanvas.SetActive(false);
    }
}
