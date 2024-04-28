using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cables : MonoBehaviour
{
    public LineRenderer cable;

    public Transform start, end;

    private void Update()
    {
        cable.SetPosition(0, start.position);
        cable.SetPosition(1, end.position);
    }
}
