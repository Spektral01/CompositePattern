using System;
using System.Collections.Generic;

public abstract class Race
{
    public virtual void Move()
    {
        Console.WriteLine("Hero is running");
    }

    public virtual void Attack()
    {
        Console.WriteLine("Hero attacks basic");
    }
}

public class OrcRace : Race
{
    public void Rage()
    {
        Console.WriteLine("Orc is furious");
    }
}

public class ElfRace : Race
{
    public void Sneak()
    {
        Console.WriteLine("Elf is hiding");
    }
}

public class HumanRace : Race
{
    public void Heal()
    {
        Console.WriteLine("Human is healing");
    }
}

public class GoblinRace : Race
{
    public void Steal()
    {
        Console.WriteLine("Goblin steals");
    }
}

public class OrderRace : Race
{
    private List<Race> races = new List<Race>();

    public void AddRace(Race race)
    {
        races.Add(race);
    }

    public void RemoveRace(Race race)
    {
        races.Remove(race);
    }

    public override void Move()
    {
        foreach (var race in races)
        {
            race.Move();
        }
    }

    public override void Attack()
    {
        foreach (var race in races)
        {
            race.Attack();
        }
    }
    public void CaptureFlagForOrder()
    {
        Console.WriteLine("Order capture flag");
    }
}
public class ChaosRace : Race
{
    private List<Race> races = new List<Race>();

    public void AddRace(Race race)
    {
        races.Add(race);
    }

    public void RemoveRace(Race race)
    {
        races.Remove(race);
    }

    public override void Move()
    {
        foreach (var race in races)
        {
            race.Move();
        }
    }
    public void CaptureFlagForChaos()
    {
        Console.WriteLine("Chaos capture flag");
    }

    public override void Attack()
    {
        foreach (var race in races)
        {
            race.Attack();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        OrcRace orc = new OrcRace();
        ElfRace elf = new ElfRace();
        HumanRace human = new HumanRace();
        GoblinRace goblin = new GoblinRace();

        ChaosRace compositeRaceChaos = new ChaosRace();
        compositeRaceChaos.AddRace(orc);
        compositeRaceChaos.AddRace(goblin);

        compositeRaceChaos.Move(); // Выполнить перемещение для всех добавленных рас
        compositeRaceChaos.Attack(); // Выполнить прыжок для всех добавленных рас
        compositeRaceChaos.CaptureFlagForChaos();
        orc.Rage();
        goblin.Steal();

        OrderRace compositeRaceOrder = new OrderRace();
        compositeRaceOrder.AddRace(human);
        compositeRaceOrder.AddRace(elf);

        compositeRaceOrder.Move(); // Выполнить перемещение для всех добавленных рас
        compositeRaceOrder.Attack(); // Выполнить прыжок для всех добавленных рас
        compositeRaceChaos.CaptureFlagForOrder();
        human.Heal();
        elf.Sneak();
    }
}
