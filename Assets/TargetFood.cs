using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetFood : MonoBehaviour
{
    public GameObject target0;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject prompt;
    public Texture targetTexture0;
    public Texture targetTexture2;
    public Texture targetTexture3;
    public Texture targetTexture4;
    public static List<int> targetedFoods;

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
            targetedFoods.Add(0);
            if (targetedFoods.Count >= 2) {
                prompt.GetComponent<Text>().text = "恭喜你找到了2个果蔬，点击右下角图标进入选菜界面";
            }
            RawImage rawImage = target0.GetComponent<RawImage>();
            rawImage.texture = targetTexture0;
        }
    }
    public void Target2() {
        if (!targetedFoods.Contains(2)) {
            targetedFoods.Add(2);
            if (targetedFoods.Count >= 2) {
                prompt.GetComponent<Text>().text = "恭喜你找到了2个果蔬，点击右下角图标进入选菜界面";
            }
            RawImage rawImage = target2.GetComponent<RawImage>();
            rawImage.texture = targetTexture2;
        }
    }
    public void Target3() {
        if (!targetedFoods.Contains(3)) {
            targetedFoods.Add(3);
            if (targetedFoods.Count >= 2) {
                prompt.GetComponent<Text>().text = "恭喜你找到了2个果蔬，点击右下角图标进入选菜界面";
            }
            RawImage rawImage = target3.GetComponent<RawImage>();
            rawImage.texture = targetTexture3;
        }
    }
    public void Target4() {
        if (!targetedFoods.Contains(4)) {
            targetedFoods.Add(4);
            if (targetedFoods.Count >= 2) {
                prompt.GetComponent<Text>().text = "恭喜你找到了2个果蔬，点击右下角图标进入选菜界面";
            }
            RawImage rawImage = target4.GetComponent<RawImage>();
            rawImage.texture = targetTexture4;
        }
    }
}
