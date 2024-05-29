using UnityEngine;

public class Moving : MonoBehaviour
{
    public bool Sitt = false;

    public float Speed;

    private Vector3 MoveVector;
    private Vector3 MoveDirtection;

    CharacterController cc;

    public void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    public void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        MoveVector.z = Input.GetAxisRaw("Vertical");
        MoveVector.x = Input.GetAxisRaw("Horizontal");
        MoveDirtection = transform.forward * MoveVector.z + transform.right * MoveVector.x;
        MoveDirtection.y -= 9.81f;  
        cc.Move(MoveDirtection * Speed);
    }
}