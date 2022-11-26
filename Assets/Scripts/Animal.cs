using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Animal : MonoBehaviour
{
    public enum DangerLevel
    {
        easy,
        medium,
        high,
    }

    public float _Speed;
    [SerializeField]private DangerLevel dangerlevel;
    // ENCAPSULATION
    public DangerLevel _Dangerlevel { get => dangerlevel; private set => dangerlevel = value; }
    public virtual void Move()
    {
        transform.Translate(_Speed * Time.deltaTime * Vector3.up);
    }
    public virtual void Rotate(){}
}
