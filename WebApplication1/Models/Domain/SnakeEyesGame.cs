using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HelloMVC.Models.Domain {
    [JsonObject(MemberSerialization.OptIn)]
    public class SnakeEyesGame {
        [JsonProperty]
        private Dice _dice1, _dice2;

        
        public int Eye1 { get => _dice1.Pips;}
       
        public int Eye2 { get => _dice2.Pips; }

        [JsonProperty]
        public int Total { get; private set; }

        public SnakeEyesGame() {
            _dice1 = new Dice();
            _dice2 = new Dice();
        }

        public void Play() {
            _dice1.Roll();
            _dice2.Roll();
            if (Eye1 == 1 && Eye2 == 1)
                Total = 0;
            else
                Total += Eye1 + Eye2;
            
        }
    }
}
