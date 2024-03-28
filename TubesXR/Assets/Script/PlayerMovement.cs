using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform parentTransform;
    public Transform myTransform;

    private void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        myTransform.position = parentTransform.position;
        myTransform.rotation = parentTransform.rotation;
    }
}
