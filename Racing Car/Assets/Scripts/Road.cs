﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject plane;

    private Renderer planeRenderer;

    public float speed = 1f;

    private Vector2 offsett;
        
    // Start is called before the first frame update
    void Start()
    {
        planeRenderer = plane.GetComponent<Renderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        offsett.y += -speed * Time.deltaTime;
        planeRenderer.material.SetTextureOffset ("_MainTex", offsett);
        
    }
}
