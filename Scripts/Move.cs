using UnityEngine;

public class Move : MonoBehaviour
{

    private Animator flap;
    private Rigidbody2D rigidbody;
    private PolygonCollider2D collider;
    [SerializeField]private float speed;
    [SerializeField]private float jumpingPower;


// public Vector2 speed = new Vector2(50,50);

    // Call components
    private void Awake()
    {
        flap = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<PolygonCollider2D>();

    }

   private void OnMouseDown()
   {
        GetComponent<SpriteRenderer>().color = Color.red;
   }

   private void OnMouseUp()
   {
        GetComponent<SpriteRenderer>().color = Color.white;
   }

   private void FixedUpdate()
   {
     // Vector3 moveup = new Vector3(speed,0);
     // transform.Translate(moveup);
   }
   private void Update() {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

     //    Vector3 movement = new Vector3(speed * inputX, jumpingPower * inputY);
        Vector3 movement = new Vector3(0, jumpingPower * inputY);
        movement *= Time.deltaTime;
        transform.Translate(movement);

     }
}
