using UnityEngine;

public class ForceExamples : MonoBehaviour
{
    Rigidbody2D _rigidBody;
    [SerializeField] GameObject forcePosition;
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidBody.AddForce(new Vector2(0, 9.81f));
        _rigidBody.AddForceAtPosition(
            transform.right * 2.0f,
            forcePosition.transform.position
        );
        // _rigidBody.AddTorque(1.0f);
    }
}
