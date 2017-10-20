using UnityEngine;
using System.Collections;

public class VerticalSlider : MonoBehaviour {

    float speed = 0.1f;
    Vector3 position; bool isMovingDown;
    // Use this for initialization   
    void Start () {
        this.isMovingDown = true;
    }
    // Update is called once per frame 
    void Update () {
        this.position = transform.position;
        if (this.isMovingDown == true)
        {
            this.moveDown();
        } else
        {
            this.moveUp();
        }
    }
    void moveUp()
    {
        this.position.y += speed;
        transform.position = this.position;
        if (this.position.y >= -1.3f)
        {
            this.isMovingDown = true;
        }
    }
    void moveDown()
    {
        this.position.y -= speed;
        transform.position = this.position;
        if (this.position.y <= -4.0f)
        {
            this.isMovingDown = false;
        }
    }
}
