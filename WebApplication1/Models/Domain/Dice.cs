using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HelloMVC.Models.Domain {
    [JsonObject(MemberSerialization.OptIn)]

    public class Dice {
        private Random _random;
        [JsonProperty]
        public  int Pips { get; private set; }

        public Dice() {
            _random = new Random();
            Pips = 6;
        }

        public void Roll() {
            Pips = _random.Next(6)+1;
        }
    }
}
