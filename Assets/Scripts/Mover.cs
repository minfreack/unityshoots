using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    private void Update()
    {
        //Vector3 up = new Vector3(0, 1f, 0);
        transform.Translate(direction * speed * Time.deltaTime);
    }
    // public void DoMove(Vector3 moverValue)
    // {
    //     transform.Translate(moverValue);
    // }
}
