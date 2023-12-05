using System.Collections;
using System.Collections.Generic;
using UniMob.UI;
using UnityEngine;

public class CounterWidget : StatefulWidget
{
    public int IncrementStep { get; set; }
    public override State CreateState() => new CounterState();
}
