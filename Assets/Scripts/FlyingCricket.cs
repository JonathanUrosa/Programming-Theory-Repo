using UnityEngine;

public class FlyingCricket: Animal
{
    private void Update()
    {
        Move();
    }
    public override void Move()
    {
        base.Move();
        transform.Translate(_Speed * Time.deltaTime * Vector3.right);
    }
}
