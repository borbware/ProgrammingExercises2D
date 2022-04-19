using UnityEngine;

public class CollisionExamples : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "Face")
        {
            // Destroy(this.gameObject);
        }
        Debug.Log($"ENTER: {other.gameObject.name}");
    }
    private void OnCollisionStay2D(Collision2D other) {
        Debug.Log($"STAY: {other.gameObject.name}");
    }
    private void OnCollisionExit2D(Collision2D other) {
        Debug.Log($"EXIT: {other.gameObject.name}");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // if (other.gameObject.name == "Face")
            // Destroy(this.gameObject);
        Debug.Log($"TRIGGER ENTER: {other.gameObject.name}");
    }
    private void OnTriggerStay2D(Collider2D other) {
        Debug.Log($"TRIGGER STAY: {other.gameObject.name}");
    }
    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log($"TRIGGER EXIT: {other.gameObject.name}");
    }

}
