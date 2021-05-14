using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        float SpeedX = Random.Range(0,2) == 0 ? -1 : 1;
        float SpeedY = Random.Range(0,2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(Speed * SpeedX, Speed * SpeedY, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
