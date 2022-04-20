using UnityEngine;
public class BounceOff : MonoBehaviour
{
    Rigidbody2D _rigidBody;

	[System.Obsolete]
	void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.AddForce(new Vector2(Random.Range(0,3),Random.Range(0,3)));
        _rigidBody.AddTorque(Random.RandomRange(0,4));
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "Face")
        {
            var _rigidBodyOther = other.gameObject.GetComponent<Rigidbody2D>();
            _rigidBody.AddForce(_rigidBodyOther.velocity * 100);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
