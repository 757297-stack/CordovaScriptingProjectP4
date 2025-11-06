using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    public int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // create the multiply by two function
    int MultiplyByTwo(int number)
    {  
        //create a local variable
        int result;

        //multiplying the number by two
        result = number * 2;

        //return the value
        return result;
    }
    
    
      

}
    

