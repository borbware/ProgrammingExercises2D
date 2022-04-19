using UnityEngine;

public class TransformExamples : MonoBehaviour
{
    GameObject myChild;
    void Start()
    {
        myChild = transform.Find("Lapsonen").gameObject;
        Debug.Log(myChild.name);
    }

    void Translate()
    {
		if (Input.GetKey(KeyCode.UpArrow))
            myChild.transform.position += 
                new Vector3(0, -2f * Time.deltaTime, 0);
		if (Input.GetKey(KeyCode.DownArrow))
            myChild.transform.Translate(
                new Vector3(0, 2f * Time.deltaTime, 0));
    }
    void Rotate()
    {
        if (Input.GetKey(KeyCode.Space))
            transform.RotateAround(
                myChild.transform.position,
                myChild.transform.forward,
                360 * Time.deltaTime
            );
        if (Input.GetKey(KeyCode.LeftAlt))
            // transform.RotateAround(
            //     transform.position,
            //     transform.forward,
            //     180 * Time.deltaTime
            // );
            transform.localEulerAngles = new Vector3(
                0f,
                0f,
                transform.localEulerAngles.z + 180 * Time.deltaTime
            );
    }
    void Scale()
    {
        Debug.Log(myChild.transform.lossyScale);
    }
    void Update()
    {
        // Translate();
        Rotate();
        Scale();
    }
}
