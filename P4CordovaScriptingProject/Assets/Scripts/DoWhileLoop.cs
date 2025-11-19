using System.Collections;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
   
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
