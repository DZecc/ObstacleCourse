using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody gravity;
    [SerializeField] float timeToDrop = 3f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        gravity = GetComponent<Rigidbody>();

        renderer.enabled = false;
        gravity.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToDrop)
        {
            renderer.enabled = true;
            gravity.useGravity = true; 
        }
    }
}
