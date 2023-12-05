using System.Collections;
using System.Collections.Generic;
using UniMob.UI;
using UniMob;
using UnityEngine;

public class CounterState : ViewState<CounterWidget>, IConterState
{
    public override WidgetViewReference View
    {
        get => WidgetViewReference.Resource("Prefabs/CounterView");
    }

    [Atom] public int Counter { get; private set; }

    public void Increment()
    {
        // atom modification will automatically update UI
        Counter += Widget.IncrementStep;
    }
}
public interface IConterState : IViewState
{
    int Counter { get; }

    void Increment();
}