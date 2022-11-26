using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float _Speed;
    public enum DangerLevel
    {
        easy,
        medium,
        high,
    }
    public DangerLevel _Dangerlevel { get; private set; }
    public virtual void Move()
    {
        transform.Translate(_Speed * Time.deltaTime * Vector3.up);
    }
}
