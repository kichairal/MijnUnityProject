using UnityEngine;

public class GoombaMovement : MonoBehaviour
{ public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    { transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 5) - 5, transform.position.y, transform.position.z);

        
    }
}
