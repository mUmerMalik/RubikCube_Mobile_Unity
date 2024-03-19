using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int N = 5, S = 12;
        int[] A = { 1, 2, 3, 7, 5 };// Output: 2 4
        for (int i = 0; i < N; i++)
        {
            int sum = 0;
            for (int j = i; j < N; j++)
            {
                sum += A[j];
                if (sum == S)
                {
                    Debug.Log("Output: " + (i + 1) + " " + (j + 1));
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
