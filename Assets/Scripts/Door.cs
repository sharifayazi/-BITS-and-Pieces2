using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousEnviro;
    [SerializeField] private Transform nextEnviro;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
                cam.MoveToNewRoom(nextEnviro);
            else
                cam.MoveToNewRoom(previousEnviro);
        }
    }
}