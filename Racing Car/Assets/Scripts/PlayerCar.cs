using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    public bool carChangingLane;
    public float moveSpeed = 1f;

    public float targetPos;

    // Start is called before the first frame update
    void Start() {
       
    }

    // Update is called once per frame
    void Update() {
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                carChangingLane = true;
                targetPos = -4f;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) {
            carChangingLane = true;
            targetPos = 4f;

        }

        ChangeCarLane();
    }

    private void ChangeCarLane() {
        if (carChangingLane) {
            Vector3 currentPos = transform.position;

            float xPos = Mathf.Lerp (currentPos.x, targetPos, Time.deltaTime * moveSpeed);

            this.transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

            if (Mathf.Abs (currentPos.x - targetPos) < 0.05f) {
                carChangingLane = false;
            }
        }
    }
}
