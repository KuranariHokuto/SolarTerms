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
    // public GameObject text;

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
        // foreach (int data in ChooseFruit.chosenFruits) {
        //     text.GetComponent<Text>().text += data + " ";
        // }
        // text.GetComponent<Text>().text += "; ";
        // if (ChooseVegetable.chosenVegetables == null) {
        //     text.GetComponent<Text>().text += "null ";
        // }
        // foreach (int data in ChooseVegetable.chosenVegetables) {
        //     text.GetComponent<Text>().text += data + " ";
        // }
        // text.GetComponent<Text>().text += "; ";
        // foreach (int data in ChooseMeat.chosenMeats) {
        //     text.GetComponent<Text>().text += data + " ";
        // }
        // text.GetComponent<Text>().text += "; ";
        // foreach (int data in ChooseCorn.chosenCorns) {
        //     text.GetComponent<Text>().text += data + " ";
        // }
        // text.GetComponent<Text>().text += "; ";
        foreach (Transform food in eatCanvas.transform)
        {
            // text.GetComponent<Text>().text += food.gameObject.name;
            if (ChooseFruit.chosenFruits != null && ChooseFruit.chosenFruits.Contains(int.Parse(food.gameObject.name))
                || ChooseVegetable.chosenVegetables != null && ChooseVegetable.chosenVegetables.Contains(int.Parse(food.gameObject.name))
                || ChooseMeat.chosenMeats != null && ChooseMeat.chosenMeats.Contains(int.Parse(food.gameObject.name))
                || ChooseCorn.chosenCorns != null && ChooseCorn.chosenCorns.Contains(int.Parse(food.gameObject.name))) {
                // text.GetComponent<Text>().text += "true  ";
                food.gameObject.SetActive(true);
            } else {
                // text.GetComponent<Text>().text += "false  ";
                food.gameObject.SetActive(false);
            }
        }
    }

    public void TargetLost()
    {
        cookEatCanvas.SetActive(false);
        eatCanvas.SetActive(false);
    }
}
