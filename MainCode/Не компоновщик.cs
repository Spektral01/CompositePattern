using System;
using System.Collections.Generic;

namespace Pattern
{

    public class OrcRace
    {
        public void Move()
        {
            Console.WriteLine("Hero is runing");
        }
        public void Attack()
        {
            Console.WriteLine("Hero attacks basic");
        }
        public void Rage()
        {
            Console.WriteLine("Orc is furious");
        }
        public void CaptureFlagForChaos()
        {
            Console.WriteLine("Chaos capture flag");
        }
    }
    public class ElfRace
    {
        public void Move()
        {
            Console.WriteLine("Hero is runing");
        }
        public void Attack()
        {
            Console.WriteLine("Hero attacks basic");
        }
        public void Sneak()
        {
            Console.WriteLine("Elf is hiding");
        }
        public void CaptureFlagForOrder()
        {
            Console.WriteLine("Order capture flag");
        }
    }
    public class HumanRace
    {
        public void Move()
        {
            Console.WriteLine("Hero is runing");
        }
        public void Attack()
        {
            Console.WriteLine("Hero attacks basic");
        }
        public void Heal()
        {
            Console.WriteLine("Human is healing");
        }
        public void CaptureFlagForOrder()
        {
            Console.WriteLine("Order capture flag");
        }
    }
    public class GoblinRace
    {
        public void Move()
        {
            Console.WriteLine("Hero is runing");
        }
        public void Attack()
        {
            Console.WriteLine("Hero attacks basic");
        }
        public void Steal()
        {
            Console.WriteLine("Goblin steals");
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
            HumanRace human = new HumanRace();
            GoblinRace goblin = new GoblinRace();
            ElfRace elf = new ElfRace();
            OrcRace orc = new OrcRace();

            List<object> orcs = new List<object>();
            List<object> elfs = new List<object>();
            List<object> humans = new List<object>();
            List<object> goblins = new List<object>();

            orcs.Add(orc);
            goblins.Add(goblin);
            elfs.Add(elf);
            humans.Add(human);

            List<object>[] OrderRace = new List<object>[2];
            OrderRace[0] = elfs;
            OrderRace[1] = humans;
            List<object>[] ChaosRace = new List<object>[2];
            ChaosRace[0] = orcs;
            ChaosRace[1] = goblins;

            orc.Attack();
            orc.Move();
            orc.Rage();
            orc.CaptureFlagForChaos();

            human.Attack();
            human.Move();
            human.Heal();
            human.CaptureFlagForOrder();

            elf.Attack();
            elf.Move();
            elf.Sneak();
            elf.CaptureFlagForOrder();

            goblin.Attack();
            goblin.Move();
            goblin.Steal();
            goblin.CaptureFlagForChaos();
        }
    }
}
