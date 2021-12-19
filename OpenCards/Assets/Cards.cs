using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Button card;

    int[] poke = new int[54];
    int CardsCount =0;
    int a =0;
    void Start()
    {
        int i , j ;
        for(i=0; i < poke.Length ; i++)
        {
            do
            {
                poke[i] = Random.Range(1,55);
                for(j=0;j<i;j++){
                    if(poke[i] == poke[j])
                    {
                        break;
                    }
                }
            }while(j != i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(CardsCount<52){
        var cards = Instantiate(card,transform.position,new Quaternion(0,0,0,0) ,transform );
        cards.transform.position += new Vector3(-255+a,-80,0);
        cards.GetComponentInChildren<Text>().text = poke[CardsCount].ToString();
        cards.GetComponentInChildren<Text>().enabled = false;
        a +=10;
        CardsCount++;
        }
    }
}
