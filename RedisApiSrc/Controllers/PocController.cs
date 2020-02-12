using Microsoft.AspNetCore.Mvc;

namespace RedisApiSrc.Controllers
{
    [Route("poc/[action]")]
    [ApiController]
    public class PocController : ControllerBase
    {
        /// <summary>
        /// Write data to Master.
        /// </summary>
        /// <returns>string</returns>
        public IActionResult Demo1()
        {
            RedisHaFactory.RedisDB.StringSet("6379", "Write string value to 6379.");
            var stringGet = RedisHaFactory.RedisDB.StringGet("6379");
            return Ok(stringGet.ToString());
        }

        /// <summary>
        /// Write data to Slave(readonly), It will throw exception.
        /// </summary>
        /// <returns></returns>
        public IActionResult Demo2()
        {
            RedisFactory6380.RedisDB.StringSet("6380", "Write string value to 6380.");
            var stringGet = RedisFactory6380.RedisDB.StringGet("6380");
            return Ok(stringGet.ToString());
        }

        /// <summary>
        /// Shitdown Master and write to Slave(sentinel enable).
        /// </summary>
        /// <returns>string</returns>
        public IActionResult Demo3()
        {
            RedisHaFactory.RedisDB.StringSet("6379down", "Write string value to 6380.");
            var stringGet = RedisHaFactory.RedisDB.StringGet("6379down");
            return Ok(stringGet.ToString());
        }
    }
}