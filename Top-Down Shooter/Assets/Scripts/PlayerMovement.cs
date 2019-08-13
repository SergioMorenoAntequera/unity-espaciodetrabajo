using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    private Vector3 _position;
    public float movementSpeed;

    [Header("Rotation")]
    private Vector3 mousePosition;
    private Vector2 directionToLookAt;


    // Start is called before the first frame update
    void Start()
    {
        _position = Vector3.zero;
        mousePosition = Vector3.zero;
        directionToLookAt = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //////////////////////////////////////////////////////////////////////////
        // Position //////////////////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.W))
        {
            _position.y = _position.y + movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _position.x = _position.x - movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _position.y = _position.y - movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _position.x = _position.x + movementSpeed * Time.deltaTime;
        }

        //////////////////////////////////////////////////////////////////////////
        // Rotation //////////////////////////////////////////////////////////////
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        directionToLookAt.x = (mousePosition.x - transform.localPosition.x);
        directionToLookAt.y = (mousePosition.y - transform.localPosition.y);

        //rotation.Set(directionToLookAt.x, directionToLookAt.y, 0, 0);
    }

    //Here we actually apply our data to the object itself
    void FixedUpdate()
    {
        //Position
        transform.position = _position;

        //Rotation
        transform.up = directionToLookAt;
    }
}
