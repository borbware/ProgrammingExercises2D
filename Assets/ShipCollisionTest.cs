using UnityEngine;

public class ShipCollisionTest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log($"ENTER PLAYER: {other.gameObject.name}");
        other.gameObject.transform.DetachChildren();
        Destroy(other.gameObject);
    }
}
