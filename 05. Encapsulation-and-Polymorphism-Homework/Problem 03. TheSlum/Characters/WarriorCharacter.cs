using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class WarriorCharacter : Character, IAttack
    {
        public WarriorCharacter(string id, int x, int y, Team team, int healthPoints = 200, int defensePoints = 100, int range = 2, int attackPoints = 150) 
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            // Always picks the first target!!! ??????????????????????????????????????
            return targetsList.FirstOrDefault(character => character.IsAlive);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
