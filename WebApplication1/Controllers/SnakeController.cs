using HelloMVC.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HelloMVC.Controllers {
    public class SnakeController : Controller {

        private SnakeEyesGame _snakeEyesGame;
        public IActionResult Index() {
            _snakeEyesGame = new SnakeEyesGame();
            HttpContext.Session.SetString("Snake",JsonConvert.SerializeObject(_snakeEyesGame));
            return View(_snakeEyesGame);
        }

        public IActionResult Play() {
            _snakeEyesGame = JsonConvert.DeserializeObject<SnakeEyesGame>(HttpContext.Session.GetString("Snake"));
            _snakeEyesGame.Play();
            HttpContext.Session.SetString("Snake", JsonConvert.SerializeObject(_snakeEyesGame));
            if (_snakeEyesGame.Eye1 == 1 && _snakeEyesGame.Eye2 == 1)
                
            return View(nameof(Index),_snakeEyesGame);
        }
    }
}