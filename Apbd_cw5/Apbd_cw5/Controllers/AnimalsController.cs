// using Apbd_cw5.DataBase;
// using Microsoft.AspNetCore.Mvc;
//
// namespace Apbd_cw5.Controllers;
//
// [ApiController]
// [Route("/animals-controller")]
// // [Route("[controller]")]
// public class AnimalsController : ControllerBase //obsluga endpointow using controllers
// {
//     [HttpGet]
//     public IActionResult GetAnimals()
//     {
//         var animals = new MockDb().Animals;
//         return Ok(animals);
//     }
//     
//     [HttpPost]
//     public IActionResult AddAnimal()
//     {
//         return Created();
//     }
// }