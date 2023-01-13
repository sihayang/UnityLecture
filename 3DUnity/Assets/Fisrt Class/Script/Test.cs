using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster
{ 
    public Monster()
    {
        Debug.Log("Monster가 태어났습니다.");
    }
}

public class Test : MonoBehaviour
{
    public int value = 100;

    public int [] count;
    public int [] data = new int[3]; 

    void Start()
    {
        Debug.Log(value);
        Monster monster = new Monster();

        transform.position = new Vector3(0, transform.position.y, 1);

        foreach(var element in data)
        {
            Debug.Log(element);
        }
    }

    void Update()
    {
        // GetKeyDown : 키를 눌렀을 때 
        // GetKey : 키를 누르고 있을 때 
        // GetKeyUp : 키를 뗐을 때

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
    }
}
