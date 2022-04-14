using UnityEngine;

public class TestAxisInputRaw : MonoBehaviour
{
    [SerializeField] float inputScaler = 0.5f;
    void Update()
    {
        float move_x = Input.GetAxisRaw("Horizontal");
        float move_y = Input.GetAxisRaw("Vertical");
        transform.localPosition = new Vector3(move_x * inputScaler, move_y * inputScaler, 0f);
    }
}
