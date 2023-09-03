using System;
using System.Collections.Generic;

public interface IRace
{
    void Move();
    void Attack();
}

public class OrcRace : IRace
{
    public void Move()
    {
        Console.WriteLine("Orc is running");
    }

    public void Attack()
    {
        Console.WriteLine("Orc attacks basic");
    }

    public void Rage()
    {
        Console.WriteLine("Orc is furious");
    }
}

public class ElfRace : IRace
{
    public void Move()
    {
        Console.WriteLine("Elf is running");
    }

    public void Attack()
    {
        Console.WriteLine("Elf attacks basic");
    }

    public void Sneak()
    {
        Console.WriteLine("Elf is hiding");
    }
}

public class HumanRace : IRace
{
    public void Move()
    {
        Console.WriteLine("Human is running");
    }

    public void Attack()
    {
        Console.WriteLine("Human attacks basic");
    }

    public void Heal()
    {
        Console.WriteLine("Human is healing");
    }
}

public class GoblinRace : IRace
{
    public void Move()
    {
        Console.WriteLine("Goblin is running");
    }

    public void Attack()
    {
        Console.WriteLine("Goblin attacks basic");
    }

    public void Steal()
    {
        Console.WriteLine("Goblin steals");
    }
}

public class OrderRace : IRace
{
    private List<IRace> races = new List<IRace>();

    public void AddRace(IRace race)
    {
        races.Add(race);
    }

    public void RemoveRace(IRace race)
    {
        races.Remove(race);
    }

    public void Move()
    {
        foreach (var race in races)
        {
            race.Move();
        }
    }

    public void Attack()
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

public class ChaosRace : IRace
{
    private List<IRace> races = new List<IRace>();

    public void AddRace(IRace race)
    {
        races.Add(race);
    }

    public void RemoveRace(IRace race)
    {
        races.Remove(race);
    }

    public void Move()
    {
        foreach (var race in races)
        {
            race.Move();
        }
    }

    public void Attack()
    {
        foreach (var race in races)
        {
            race.Attack();
        }
    }

    public void CaptureFlagForChaos()
    {
        Console.WriteLine("Chaos capture flag");
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

        compositeRaceChaos.Move(); // Выполнить перемещение для всех добавленных рас во фракции Chaos
        compositeRaceChaos.Attack(); // Выполнить атаку для всех добавленных рас во фракции Chaos
        compositeRaceChaos.CaptureFlagForChaos();
        orc.Rage();
        goblin.Steal();

        OrderRace compositeRaceOrder = new OrderRace();
        compositeRaceOrder.AddRace(human);
        compositeRaceOrder.AddRace(elf);

        compositeRaceOrder.Move(); // Выполнить перемещение для всех добавленных рас во фракции Order
        compositeRaceOrder.Attack(); // Выполнить атаку для всех добавленных рас во фракции Order
        compositeRaceOrder.CaptureFlagForOrder();
        human.Heal();
        elf.Sneak();
    }
}
