using System;
using System.Collections;
using System.Collections.ObjectModel;

public static class Feeding
{
    // TODO make this class consistent with the static damage class.
    public static void Feed(ObservableCollection<Animal> animals)
    {
        float HealthIncrease = PercentageToIncrease();

        for (int i = 0; i < animals.Count; i++)
        {

            float animalHealth = ((Animal)animals[i]).Health;
            float animalHealthIncrease = animalHealth * HealthIncrease;


            ((Animal)animals[i]).AddHealth(animalHealthIncrease);

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


    private static float PercentageToIncrease()
    {
        int randomNumber = RandomNumberGenerator.GetRandomNumber(10, 26);
        return randomNumber / 100f;
    }
}




