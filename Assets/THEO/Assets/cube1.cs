using UnityEngine;

public class joueur2 : MonoBehaviour
{
    public float MovementSpeed = 100;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.Play("idle");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            animator.Play("" +
                "punch1");

            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        }
    }
}
