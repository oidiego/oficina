using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{
    public int totalScore;
    public static controle instance;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    
}

