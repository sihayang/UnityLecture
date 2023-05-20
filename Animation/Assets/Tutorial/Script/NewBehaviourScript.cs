using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 direction = new Vector3(1,1,1);

    void Start()
    {
        print(transform.position); // 0,0,0
        Move(transform);
        print(transform.position); // 5,5,5
    }

    public void Move(Transform dir)
    {
        dir.position = new Vector3(5, 5, 5);
    }


}
