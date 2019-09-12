using System;

class Elephant : Animal {

    private Boolean _belowHealthForHour = false;

    public Elephant() {
        SetHealthString();
    }

    public override void SetHealthString()
    {
        if (Died)
        {
            return;
        }
        else if (this.Health > 70f && _belowHealthForHour)
        {
            _belowHealthForHour = false;
            base.HealthString = Health.ToString() + "%";
        }
        else if (this.Health < 70f && _belowHealthForHour)
        {
            base.HealthString = "Dead";
            Died = true;
        }
        else if (this.Health < 70f)
        {
            base.HealthString = "Cant Walk";
            _belowHealthForHour = true;
        }
        else base.HealthString = Health.ToString() + "%";
    }

}