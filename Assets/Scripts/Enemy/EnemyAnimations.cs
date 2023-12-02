using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidBody;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float speed = rigidBody.velocity.magnitude;
        animator.SetFloat("Speed", speed);

        // Other logic for movement...
    }
}

