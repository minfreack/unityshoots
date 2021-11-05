using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackgraund : MonoBehaviour
{
    // Material material;
    // Vector2 offset;
    // public int xVelocity, yVelocity;

    // private void Awake () {
    //     material = GetComponent<Renderer>().material;
    // }
    // // Start is called before the first frame update
    // void Start()
    // {
    //     offset = new Vector2(xVelocity, yVelocity);

    // }

    // Update is called once per frame
    public float scrollSpeed = 0.05f;
    [SerializeField] private MeshRenderer mesh;
    void Update()
    {
        //material.mainTextureOffset += offset * Time.deltaTime;
        Vector2 offset = new Vector2(0, Time.time * scrollSpeed);
        mesh.material.mainTextureOffset = offset;
    }
}
