using UnityEngine;

public class MoveFace : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float walkSpeed = 2f;
    [SerializeField] float jumpStrength = 20f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     transform.position += new Vector3(- walkSpeed * Time.deltaTime,0f,0f);
        // }
        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.position += new Vector3(walkSpeed * Time.deltaTime,0f,0f);
        // }
        float move_x = Input.GetAxis("Horizontal");
        if (move_x > 0)
        {
             transform.position += new Vector3(move_x * walkSpeed * Time.deltaTime,0f,0f);
        } else if (move_x < 0)
        {
             transform.position += new Vector3(move_x * walkSpeed * 2 * Time.deltaTime,0f,0f);
        }
        if (Input.GetButtonDown("Jump"))
        {
            transform.position += new Vector3(0f, jumpStrength, 0f);
        }

    }
}
