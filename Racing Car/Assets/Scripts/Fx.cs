using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fx : MonoBehaviour
{
    public GameObject obstacleCar;

    // Start is called before the first frame update
    void Start() {
        InvokeRepeating ("GenerateObstacleCars", 1f,5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GenerateObstacleCars() {

        int randomNum = Random.Range(0, 2);

        if(randomNum == 0)
        {
            Instantiate(obstacleCar, new Vector3(-4f, 31f, 0f), Quaternion.identity);
        }
        else
        {
            Instantiate(obstacleCar, new Vector3(4f, 31f, 0f), Quaternion.identity);
        }
    }
}
