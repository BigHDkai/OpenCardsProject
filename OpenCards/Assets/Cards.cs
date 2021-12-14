using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Button card;

    int i =0;
    int a =0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(i<52){
        var cards =Instantiate(card ,transform.position,new Quaternion(0,0,0,0) ,transform );
        cards.transform.position += new Vector3(-255+a,-160,0);
        a +=10;
        i++;
        Debug.Log(i);
        }
    }

    public void CardsUp()
    {
        if(transform.position.y == -160)
        {
            transform.position += new Vector3(0,10,0);
        }
    }
}
