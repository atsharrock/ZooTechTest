using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows.Threading;

public class ZooTime : ObservableObject
{

    private DispatcherTimer _dispatcherTimer;
    private DateTime _datetime;
    private String _time;
    public String Time
    {
        get { return _time; }
        set
        {
            _time = value;
            OnPropertyChanged("Time");
        }
    }

    private String _timeInOneHour;
    private ObservableCollection<ObservableCollection<Animal>> _allAnimals;
    public ObservableCollection<ObservableCollection<Animal>> AllAnimals
    {
        get { return _allAnimals; }
        set { _allAnimals = value; }
    }

    public ZooTime(ObservableCollection<ObservableCollection<Animal>> collectionOfAnimals)
    {
        SetTimeAndDay();
        _dispatcherTimer = new DispatcherTimer();
        _dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
        _dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        _dispatcherTimer.Start();
        AllAnimals = collectionOfAnimals;
    }

    private void dispatcherTimer_Tick(object sender, EventArgs e)
    {
        _datetime = _datetime.AddMinutes(3);
        Time = _datetime.ToString("HH:mm");

        if (Time.Equals(_timeInOneHour))
        {
            Damage.DamageAnimals(AllAnimals);
            _timeInOneHour = _datetime.AddHours(1).ToString("HH:mm");
        }

    }

    private void SetTimeAndDay()
    {
        _datetime = DateTime.Now;
        TimeSpan timespan = new TimeSpan(0, 0, 0);
        _datetime = _datetime.Date + timespan;
        _time = _datetime.ToString("HH:mm");
        _timeInOneHour = _datetime.AddHours(1).ToString("HH:mm");
    }

}
