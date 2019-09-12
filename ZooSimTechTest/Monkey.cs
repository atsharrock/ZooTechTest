using System;

class Monkey : Animal {

  public Monkey() {
        SetHealthString();
  }

    public override void SetHealthString()
    {
        if (Died)
        {
            return;
        }
        else if (this.Health < 30f)
        {
            Died = true;
            base.HealthString = "Dead";
        }
        else base.HealthString = Health.ToString() + "%";
    }

}