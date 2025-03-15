using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigitbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigitbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
