using System.Collections;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    public int numEnemies = 3;

    void Start()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
