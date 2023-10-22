using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aicubescript : MonoBehaviour
{
    int health = 2;
    int level = 1;
    float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("здоровье:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.z += speed * Time.deltaTime;

        transform.position = newPos;
    }
}
