using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageChange : MonoBehaviour {

    public Sprite Texture_UI_MainMenu_01;
    public List<Sprite> SpriteList;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PutImage()
    {
        SpriteList.Add(Resources.Load<Sprite>("Paul"));
        SpriteList.Add(Resources.Load<Sprite>("Jim"));
        SpriteList.Add(Resources.Load<Sprite>("Tom"));
        SpriteList.Add(Resources.Load<Sprite>("Ralph"));
        Button mybutton = GameObject.Find("MyButton").GetComponent<Button>();
        mybutton.image.sprite = SpriteList[0];
        Debug.Log("I made it here");


    }
}
