using Microsoft.AspNetCore.Mvc;

namespace DateAndTime_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [HttpGet]
        [Route("CurrentDate")]
        public IActionResult GetCurrentDate()
        {
            return Ok(DateTime.Now.ToString());
        }

        [HttpGet]
        [Route("GetLondonDate")]
        public IActionResult GetLondonDate()
        {
            return Ok(DateTime.UtcNow.ToString());
        }

        [HttpGet]
        [Route("DaysBetweenDates")]
        public IActionResult DaysBetween(DateTime startDate, DateTime endDate)
        {
            TimeSpan span = endDate.Date - startDate.Date;
            return Ok(Math.Abs(span.Days));
        }

        [HttpGet]
        [Route("IsLeapYear")]
        public IActionResult IsLeapYear(int year)
        {
            return Ok(DateTime.IsLeapYear(year));
        }

        [HttpGet]
        [Route("FirstDayOfPreviousMonth")]
        public IActionResult FirstDayOfPreviousMonth()
        {
            var currentDate = DateTime.Now;

            var previousMonthDate = currentDate.AddMonths(-1);

            var firstDayOfPreviousMonth = new DateTime(previousMonthDate.Year, previousMonthDate.Month, 1);

            return Ok(firstDayOfPreviousMonth);
        }

        [HttpGet]
        [Route("LastDayOfPreviousMonth")]
        public IActionResult LastDayOfPreviousMonth()
        {
            var currentDate = DateTime.Now;

            var firstDayOfPreviousMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

            var lastDayOfPreviousMonth = firstDayOfPreviousMonth.AddDays(-1);

            return Ok(lastDayOfPreviousMonth);
        }

        [HttpGet]
        [Route("CurrentWeekDay")]
        public IActionResult CurrentWeekDay()
        {
            var currentWeekDay = Convert.ToInt16(DateTime.Now.DayOfWeek);
            
            return Ok(DayOfWeekGeorgian[currentWeekDay]);
        }
        public Dictionary<int, string> DayOfWeekGeorgian = new Dictionary<int, string>()
        {
            { 0, "კვირა" },
            { 1, "ორშაბათი" },
            { 2, "სამშაბათი" },
            { 3, "ოთხშაბათი" },
            { 4, "ხუთშაბათი" },
            { 5, "პარასკევი" },
            { 6, "შაბათი" }
        };
    }
}
