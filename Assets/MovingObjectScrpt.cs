using UnityEngine;

public class MovingObjectScrpt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int moveSpeed = 30;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movingObject();
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            moveSpeed += 10;
        }
        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            moveSpeed -= 10;
        }
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            moveSpeed = 30;
        }
    }

    private void movingObject()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position += Vector3.back * Time.deltaTime * moveSpeed;
        }
    }
}