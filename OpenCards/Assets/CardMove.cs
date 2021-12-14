using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMove : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CardsUp()
    {
        
        transform.position += new Vector3(0,a,0);
        a -=10;
    }

    public void CardsShow()
    {
        if(a==-10)
        {
            transform.position = transform.parent.position;
        }
    }


}
