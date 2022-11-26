using UnityEngine;

// INHERITANCE
public class Flies : Animal
{
    private void Update()
    {
        Move();
    }
    // POLYMORPHISM
    public override void Move()
    {
        transform.Translate(_Speed * Time.deltaTime * Vector3.down);
    }
}
