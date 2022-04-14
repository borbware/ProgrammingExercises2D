using UnityEngine;

public class TestAxisInput : MonoBehaviour
{
    [SerializeField] float inputScaler = 0.5f;
    void Update()
    {
        float move_x = Input.GetAxis("Horizontal");
        float move_y = Input.GetAxis("Vertical");
        transform.localPosition = new Vector3(move_x * inputScaler, move_y * inputScaler, 0f);
    }
}
