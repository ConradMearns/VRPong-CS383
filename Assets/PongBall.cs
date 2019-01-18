using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{

    public GameObject playerScore;
    public GameObject enemyScore;

    public int player_points = 0;
    public int enemy_points = 0;

    public float force = 10f;

    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
      gameObject.GetComponent<Rigidbody>().AddForce(0, 0, -force);
    }

    // Update is called once per frame
    void Update()
    {
      Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
      Vector3 tvel = rigidbody.velocity.normalized * speed;
      rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, tvel, Time.deltaTime);

      playerScore.GetComponent<TextMesh>().text = ""+player_points;
      enemyScore.GetComponent<TextMesh>().text = ""+enemy_points;
    }

    void OnCollisionEnter(Collision c)
    {
      if(c.collider.name == "Player Wall")
      {
        enemy_points++;
      }
      else if(c.collider.name == "Enemy Wall") {
        player_points++;
      }
      // Debug.Log(c.collider.name);
    }

}
