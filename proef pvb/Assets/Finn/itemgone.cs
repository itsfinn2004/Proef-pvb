using UnityEngine;

public class itemgone : MonoBehaviour
{
    private Vector3 startPosition;
    public float boundsLimit = 50f;
    public Color boundsColor = Color.red;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (IsOutOfBounds())
        {
            TeleportToStart();
        }
    }

    bool IsOutOfBounds()
    {
        return Vector3.Distance(startPosition, transform.position) > boundsLimit;
    }

    void TeleportToStart()
    {
        transform.position = startPosition;
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
    }

    // Draw the bounds in the Scene view
    void OnDrawGizmosSelected()
    {
        Gizmos.color = boundsColor;
        Gizmos.DrawWireSphere(Application.isPlaying ? startPosition : transform.position, boundsLimit);
    }

}

