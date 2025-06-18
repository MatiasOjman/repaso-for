using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repasoFor : MonoBehaviour
{ public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; i <= 40; i += 2)
        {
            Debug.Log(i);
        }
        //multiplos
        for (int i=num1;i<num2;i+=num1)
        {
            Debug.Log(i);
        }
        //saltear
        for (int i = 100; i>=10;i--)
        {
           if (i == 33)
            {
                continue;
            }
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
