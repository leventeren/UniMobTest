using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniMob.UI;
using TMPro;
using UniMob;

public class CounterView : View<IConterState>
{
    public TextMeshProUGUI counterText;
    public UnityEngine.UI.Button incrementButton;

    protected override void Awake()
    {
        base.Awake();
        incrementButton.Click(() => State.Increment);
    }

    protected override void Render()
    {
        counterText.text = "Conter: " + State.Counter;
    }
}