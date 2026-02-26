using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;

    [Header("Debug")]
    public bool enableDebug = false;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0f, v) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        if (enableDebug && (Mathf.Abs(h) > 0.01f || Mathf.Abs(v) > 0.01f))
        {
            Debug.Log("Player position: " + transform.position);
        }
    }
}
