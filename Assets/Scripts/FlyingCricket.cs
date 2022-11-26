using UnityEngine;

public class FlyingCricket: Animal
{
    [SerializeField]float _SpeedRotate;
    private void Update()
    {
        Move();

        if(_Dangerlevel == DangerLevel.medium)
        {
            // ABSTRACTION
            Rotate();
        }
    }
    // POLYMORPHISM
    public override void Move()
    {
        base.Move();
        transform.Translate(_Speed * Time.deltaTime * Vector3.right);
    }
    public void Rotate()
    {
        transform.Rotate(_SpeedRotate * Time.deltaTime * Vector3.forward);
    }
}
