using System;

class Giraffe : Animal
{

    public Giraffe()
    {
        SetHealthString();
    }

    public override void SetHealthString()
    {
        if (Died)
        {
            return;
        }
        else if (this.Health < 50f)
        {
            Died = true;
            base.HealthString = "Dead";
        }
        else base.HealthString = Health.ToString() + "%";
    }

}