using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// Player Movement Speed
    /// </summary>
    public float moveSpeed = 5f;

    /// <summary>
    /// Physics for our player character
    /// </summary>
    public Rigidbody2D rb;

    /// <summary>
    /// Position of character on current time
    /// </summary>
    private Vector2 movement;

    /// <summary>
    /// Animations of player
    /// </summary>
    public Animator animator;

    /// <summary>
    /// Audio sound of steps
    /// </summary>
    public AudioSource steps;

    private string currentState;

    const string PLAYER_IDLE = "Player_Idle";
    const string PLAYER_WALK_LEFT = "Player_Walk_Left";
    const string PLAYER_WALK_RIGHT = "Player_Walk_Right";
    const string PLAYER_WALK_UP = "Player_Walk_Up";
    const string PLAYER_WALK_DOWN = "Player_Walk_Down";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // Update is called once per event need
    void FixedUpdate()
    {
        if (movement.x != 0 || movement.y != 0)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

            if (movement.x > 0)
            {
                ChangeAnimationState(PLAYER_WALK_RIGHT);
                steps.enabled = true;
            }
            else if (movement.x < 0)
            {
                ChangeAnimationState(PLAYER_WALK_LEFT);
                steps.enabled = true;
            }
            else if (movement.y > 0)
            {
                ChangeAnimationState(PLAYER_WALK_UP);
                steps.enabled = true;
            }
            else if (movement.y < 0)
            {
                ChangeAnimationState(PLAYER_WALK_DOWN);
                steps.enabled = true;
            }
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
            ChangeAnimationState(PLAYER_IDLE);
            steps.enabled = false;
        }
    }

    // Animation state changer
    void ChangeAnimationState(string newState)
    {
        // Stop animation from interrupting itself
        if (currentState == newState) return;

        // Play new animation
        animator.Play(newState);

        // Update current state
        currentState = newState;
    }
}
