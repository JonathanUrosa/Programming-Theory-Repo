using UnityEngine;

// INHERITANCE
public class Bee : Animal
{
    private void Update()
    {
        Move();
    }
    // POLYMORPHISM
    public override void Move()
    {
        transform.Translate(_Speed * Time.deltaTime * Vector3.right);
    }
}
