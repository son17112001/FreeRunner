using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float moveSpeed = 3;
    float leftRightSpeed = 4;

    // Start is called before the first frame update
    // void Start()
    // {

    // }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && this.gameObject.transform.position.x > LevelBoundary.leftSide)
        {

            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed, Space.World);
        }
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))&& this.gameObject.transform.position.x < LevelBoundary.rightSide)
        {
            transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed, Space.World);
        }

    }
}
