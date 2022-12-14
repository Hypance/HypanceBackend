using Hypance.Core.Domain;
using Hypance.Core.Domain.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Hypance.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetIntervals()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(Interval)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(Interval), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetMarkets()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(Market)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(Market), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetMessageChannels()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(MessageChannel)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(MessageChannel), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetOrderTypes()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(OrderType)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(OrderType), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetPositionTypes()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(PositionType)).ToList().ForEach(x =>  list.Add( new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(PositionType), x)).ToString() })  );
            return  Ok(list);
        }
        [HttpGet]
        public IActionResult GetSignalResults()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(SignalResult)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(SignalResult), x)).ToString() }));
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetTrendStrategies()
        {
            var list = new List<SelectListItem>();
            Enum.GetNames(typeof(TrendStrategy)).ToList().ForEach(x => list.Add(new SelectListItem { Text = x, Value = ((int)Enum.Parse(typeof(TrendStrategy), x)).ToString() }));
            return Ok(list);
        }

    }
}
