using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject ball;
    public float speed = 1.0f;
    private float z_snap;

    // Start is called before the first frame update
    void Start()
    {
      z_snap = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
      float step = speed * Time.deltaTime;

      transform.position = Vector3.MoveTowards(transform.position, ball.transform.position, step);

      transform.position = new Vector3(transform.position.x, transform.position.y, z_snap);
    }
}
