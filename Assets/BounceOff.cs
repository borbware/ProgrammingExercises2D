using UnityEngine;
public class BounceOff : MonoBehaviour
{
    Rigidbody2D _rigidBody;
    [SerializeField] ManageScore _manageScore;
    GameObject _scoreManager;
	void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.AddForce(new Vector2(Random.Range(0,3),Random.Range(0,3)));
        _rigidBody.AddTorque(Random.Range(0,4));

        _scoreManager = GameObject.Find("ScoreManager");
        _manageScore = _scoreManager.GetComponent<ManageScore>();

    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "Face")
        {
            var _rigidBodyOther = other.gameObject.GetComponent<Rigidbody2D>();
            _rigidBody.AddForce(_rigidBodyOther.velocity * 100);
            _manageScore.AddToScore(10);
            // ManageScore.instance.AddToScore(10); 
        }
    }
}
