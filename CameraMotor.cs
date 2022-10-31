using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform player;
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        
        // Check if we're inside the bounds of X axis
        float deltaX = player.position.x - transform.position.x;
        if (deltaX < -boundX || deltaX > boundX)
        {
            if (transform.position.x < player.position.x)
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        // Check if we're inside the bounds of Y axis
        float deltaY = player.position.y - transform.position.y;
        if (deltaY < -boundY || deltaY > boundY)
        {
            if (transform.position.y < player.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
