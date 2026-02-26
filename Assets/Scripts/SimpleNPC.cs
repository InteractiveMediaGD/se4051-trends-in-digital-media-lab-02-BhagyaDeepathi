using UnityEngine;

public class SimpleNPC : MonoBehaviour
{
    [Header("References")]
    public Transform player;

    [Header("Behavior")]
    public float chaseDistance = 6f;
    public float moveSpeed = 2f;

    [Header("Debug")]
    public bool enableDebug = false;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (enableDebug)
            Debug.Log("Distance to player: " + distance);

        if (distance <= chaseDistance)
        {
            Vector3 lookPos = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.LookAt(lookPos);

            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}