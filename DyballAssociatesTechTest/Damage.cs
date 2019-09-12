using System;
using System.Collections;
using System.Collections.ObjectModel;

public static class Damage
{

    public static void DamageAnimals(ObservableCollection<ObservableCollection<Animal>> allAnimals)
    {
        foreach (ObservableCollection<Animal> animalCollection in allAnimals)
        {
            Damage.DamageAnimals(animalCollection);
        }
    }

    private static void InflictDamage(ObservableCollection<Animal> animals)
    {
        
        for (int i = 0; i < animals.Count; i++)
        {
            float percentToDamage = PercentAmountToDamage();
            float damageToInflict = animals[i].Health * percentToDamage;
            if (animals[i].Health - damageToInflict < 1)
            {
                ((Animal)animals[i]).Health = 0;
            }
            else
            {
                ((Animal)animals[i]).InflictDamage(damageToInflict);
                if (animals[i] is Monkey)
                {
                    (animals[i] as Monkey).SetHealthString();
                }
                if (animals[i] is Giraffe)
                {
                    (animals[i] as Giraffe).SetHealthString();
                }
                if (animals[i] is Elephant)
                {
                    (animals[i] as Elephant).SetHealthString();
                }
            }
        }
        
    }

    private static float PercentAmountToDamage()
    {
        int randomNumber = RandomNumberGenerator.GetRandomNumber(0, 21);
        return randomNumber / 100f; 
    }

    public static void DamageAnimals(ObservableCollection<Animal> animals)
    {
        InflictDamage(animals);
    }

}