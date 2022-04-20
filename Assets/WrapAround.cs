using UnityEngine;

public class WrapAround : MonoBehaviour
{
    // MAX values are offsets from camera origin
    // Keep camera in 0,0 position for easy calculation
    const float MAX_X = 9.0f;
    const float MAX_Y = 5.0f;

    void Update()
    {
        // If transform goes out of range, wrap it around by teleporting it to the other side
        // MAX is multiplied by two because it is calculated from center, multiplying by two we get the other edge

        if (transform.position.x > MAX_X)
        {
            transform.position -= Vector3.right * MAX_X * 2.0f;
        }

        if (transform.position.x < -MAX_X)
        {
            transform.position += Vector3.right * MAX_X * 2.0f;
        }

        if (transform.position.y > MAX_Y)
        {
            transform.position -= Vector3.up * MAX_Y * 2.0f;
        }

        if (transform.position.y < -MAX_Y)
        {
            transform.position += Vector3.up * MAX_Y * 2.0f;
        }
    }
}
