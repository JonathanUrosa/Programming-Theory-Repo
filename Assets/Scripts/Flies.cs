using UnityEngine;

public class Flies : Animal
{
    private void Update()
    {
        Move();
    }
    public override void Move()
    {
        transform.Translate(_Speed * Time.deltaTime * Vector3.down);
    }
}
