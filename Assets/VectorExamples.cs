using UnityEngine;

public class VectorExamples : MonoBehaviour
{
    // Start is called before the first frame update
    float epsilon = 0.000001f;
    Rigidbody2D _rigidBody;
    [SerializeField] GameObject vihu;
    [SerializeField] Vector2 exampleVector;
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate() {
        //Vector3 displacement = new Vector3(0,100f * Time.deltaTime,0);
        // _rigidBody.AddForce(displacement);
        // Debug.Log(_rigidBody.velocity);    
    }
    // Update is called once per frame
    void Update()
    {
        //Vector3 displacement = new Vector3(0,100f * Time.deltaTime,0);
        // transform.position += displacement;
        
        //float scaleFactor = 0.99f;
        //transform.position *= scaleFactor;
        if (Mathf.Abs(transform.position.x) < epsilon)
            transform.position = new Vector3(
                0,
                transform.position.y,
                transform.position.z
            );
        if (Mathf.Abs(transform.position.y) < epsilon)
            transform.position = new Vector3(
                transform.position.x,
                0,
                transform.position.z
            );

            // Debug.Log(Vector2.Distance(
            //     transform.position, 
            //     vihu.transform.position
            // ));
            // Vector2.distance
            // Vector3 distVector = transform.position - vihu.transform.position
            // distance = distVector.Magnitude

            exampleVector = transform.up;

    }
}
