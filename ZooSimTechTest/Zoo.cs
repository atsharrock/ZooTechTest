using System.Collections.ObjectModel;

public class Zoo : ObservableObject
{

    private ZooTime _zootime;
    public ZooTime Zootime
    {
        get { return _zootime; }
        set
        {
            _zootime = value;
            OnPropertyChanged("Zootime");
        }
    }

    private ObservableCollection<Animal> _Monkeys;
    public ObservableCollection<Animal> Monkeys
    {
        get { return _Monkeys; }
        set { _Monkeys = value; }
    }
    private ObservableCollection<Animal> _Elephants;
    public ObservableCollection<Animal> Elephants
    {
        get { return _Elephants; }
        set { _Elephants = value; }
    }
    private ObservableCollection<Animal> _Giraffes;
    public ObservableCollection<Animal> Giraffes
    {
        get { return _Giraffes; }
        set { _Giraffes = value; }
    }

    public Zoo()
    {
        _Monkeys = new ObservableCollection<Animal>();
        _Elephants = new ObservableCollection<Animal>();
        _Giraffes = new ObservableCollection<Animal>();
        AddAnimalsToZoo(5);
        ObservableCollection<ObservableCollection<Animal>> animals = new ObservableCollection<ObservableCollection<Animal>>() { Monkeys, Giraffes, Elephants };
        _zootime = new ZooTime(animals);
    }

    private void AddAnimalsToZoo(int numberOfAnimalsEach)
    {
        for (int i = 0; i < numberOfAnimalsEach; i++)
        {
            _Monkeys.Add(new Monkey());
            _Elephants.Add(new Elephant());
            _Giraffes.Add(new Giraffe());
        }
    }


}