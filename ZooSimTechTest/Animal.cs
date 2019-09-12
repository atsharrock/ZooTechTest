using System;

public abstract class Animal : ObservableObject
{
    private string _healthString;
    public String HealthString
    {
        get { return _healthString; }
        set
        {
            _healthString = value;
            OnPropertyChanged("HealthString");
        }
    }

    private Boolean _died = false;
    public Boolean Died
    {
        get { return _died; }
        set { _died = value; } 
    }

    private float _health = 100f;
    public float Health
    {
        get { return _health; }
        set
        {
            _health = value;
            OnPropertyChanged("Health");
        }
    }

    public void InflictDamage(float amountOfDamage)
    {
        if (_health < 0f)
        {
            Died = true;
            return;
        }
        else
        {
            _health -= (float)Math.Round(amountOfDamage);
        }

    }

    public void AddHealth(float amountOfHealth)
    {
        if (_health + amountOfHealth >= 100f)
        {
            _health = 100f;
        }
        else
        {
            _health += (float)Math.Round(amountOfHealth);
        }
    }

    public virtual void SetHealthString() { }
}
