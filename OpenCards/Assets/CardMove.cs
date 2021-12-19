using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardMove : MonoBehaviour
{
    // Start is called before the first frame update
    string state = "";

    [SerializeField]  Image myImage;   

    // Update is called once per frame

    //int asd = 
    void Start()
    {

    }

    public void CardsClick()
    {
        if(state == "cardsup")
        {
            CardsShow();
        }else
        {
            CardsUp();
        }
    }


    void CardsUp()
    {
        transform.position += new Vector3(0,10,0);
        state = "cardsup";
        
    }

    void CardsShow()
    {
        transform.position = transform.parent.position;
       // this.GetComponentInChildren<Text>().enabled = true;
        transform.SetSiblingIndex(this.transform.parent.childCount-1);
        string PokeImgCount = "PokeImage/" + this.GetComponentInChildren<Text>().text;
        myImage.sprite = Resources.Load<Sprite>(PokeImgCount);
    }


}
