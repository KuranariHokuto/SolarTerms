using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetFood : MonoBehaviour
{
    public static List<int> targetedFoods;
    public GameObject food;

    // Start is called before the first frame update
    void Start()
    {
        targetedFoods = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Target0() {
        if (!targetedFoods.Contains(0)) {
            FoodType.ChangeByName("Fruit");
            targetedFoods.Add(0);
            OpenFood.availableFruits.Add(0);
            food.GetComponent<OpenFood>().AddFood(0, "Fruit");
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
        }
    }
    public void Target1() {
        if (!targetedFoods.Contains(1)) {
            FoodType.ChangeByName("Fruit");
            targetedFoods.Add(1);
            OpenFood.availableFruits.Add(1);
            food.GetComponent<OpenFood>().AddFood(1, "Fruit");
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
        }
    }
    public void Target2() {
        if (!targetedFoods.Contains(2)) {
            FoodType.ChangeByName("Fruit");
            targetedFoods.Add(2);
            OpenFood.availableFruits.Add(2);
            food.GetComponent<OpenFood>().AddFood(2, "Fruit");
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
        }
    }
    public void Target3() {
        if (!targetedFoods.Contains(3)) {
            FoodType.ChangeByName("Fruit");
            targetedFoods.Add(3);
            OpenFood.availableFruits.Add(3);
            food.GetComponent<OpenFood>().AddFood(3, "Fruit");
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
        }
    }
    public void Target4() {
        if (!targetedFoods.Contains(4)) {
            FoodType.ChangeByName("Vegetable");
            targetedFoods.Add(4);
            OpenFood.availableVegetables.Add(4);
            food.GetComponent<OpenFood>().AddFood(4, "Vegetable");
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
        }
    }
    public void Target5() {
        if (!targetedFoods.Contains(5)) {
            FoodType.ChangeByName("Vegetable");
            targetedFoods.Add(5);
            OpenFood.availableVegetables.Add(5);
            food.GetComponent<OpenFood>().AddFood(5, "Vegetable");
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
        }
    }
    public void Target6() {
        if (!targetedFoods.Contains(6)) {
            FoodType.ChangeByName("Vegetable");
            targetedFoods.Add(6);
            OpenFood.availableVegetables.Add(6);
            food.GetComponent<OpenFood>().AddFood(6, "Vegetable");
            if (!OpenFood.inited) {
                food.GetComponent<OpenFood>().Change();
            }
        }
    }
}
