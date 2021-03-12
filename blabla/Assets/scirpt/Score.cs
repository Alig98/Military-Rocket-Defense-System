using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int money=0;
    public Text score;

    void Update()
    {
        score.text = money.ToString()+"$";
    }
}
