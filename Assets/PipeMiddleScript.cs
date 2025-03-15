using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        //logic.addScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hello");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("test"))
        {
            Debug.Log("trigerred test");
        }
        Debug.Log("trigerred middle pipe");
        logic.addScore();
        //if (collision.gameObject.layer == 3)
        //{
        //    logic.addScore(1);
        //}
    }
}
