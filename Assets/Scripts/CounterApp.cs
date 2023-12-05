using UniMob;
using UniMob.UI;

public class CounterApp : UniMobUIApp
{
    protected override Widget Build(BuildContext context)
    {
        return new CounterWidget()
        {
            IncrementStep = 1
        };
    }
}