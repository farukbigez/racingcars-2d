using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCar : MonoBehaviour {

    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(-transform.up * Time.deltaTime * moveSpeed); }
    
          
  
 }

