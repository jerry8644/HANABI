using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int number_ ;
    [SerializeField] private string color_ ;
    static int totalNumCard = 30;

    public int getNumber(){
        return number_;
    }

    public void ChangeNumber(int n){
        number_ = n;
        return;
    }

    public string getColor(){
        return color_;
    }
    
    public void Play(){

    }
    public Card(string color, int number){
        color_  = color;
        number_ = number;
    }
}
