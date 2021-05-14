using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float Speed = 5f;
    public bool IsRight;

    // Update is called once per frame
    void Update()
    {
        if (IsRight)
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * Speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * Speed * Time.deltaTime, 0f);
        }
    }
}
