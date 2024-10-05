using LogAPI.Models;
using LogCommon;
using LogCommon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogAPI.Controllers
{
    [ApiController]
    [Route("api/logs[controller]")]
    public class LogController : ControllerBase
    {
        private SQL _sql = new SQL();

        [HttpGet("GetAllLogEntries")]
        public IActionResult Index()
        {
            try
            {
                return Ok(_sql.Logs.ToList());
            }catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("GetLogEntry/{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                if (!_sql.Logs.Any(x => x.Id == id)) throw new ArgumentException("Id not found");
                return Ok(_sql.Logs.FirstOrDefault(x => x.Id == id));
            }catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }catch( Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("SearchLogEntry")]
        public IActionResult Search(LogSearch logSearch)
        {
            var all = _sql.Logs.ToList();
            if (logSearch == null) return BadRequest();
            if(logSearch.Id > 0&&logSearch.Id!=null)
            {
                var temp = all.Where(x=> x.Id==logSearch.Id).ToList();
                all = temp;
            }
            if (!string.IsNullOrWhiteSpace(logSearch.Level))
            {
                var temp = all.Where(x => x.Level == logSearch.Level).ToList();
                all = temp;
            }
            if (!string.IsNullOrWhiteSpace(logSearch.Message))
            {
                var temp = all.Where(x => x.Message == logSearch.Message).ToList();
                all = temp;
            }
            if (!string.IsNullOrWhiteSpace(logSearch.Logger))
            {
                var temp = all.Where(x => x.Logger == logSearch.Logger).ToList();
                all = temp;
            }
            if(logSearch.CorrelationId!=Guid.Empty)
            {
                var temp = all.Where(x => x.CorrelationId == logSearch.CorrelationId).ToList();
                all = temp;
            }
            if (logSearch.Thread != null)
            {
                var temp = all.Where(x=>x.CorrelationId == logSearch.CorrelationId).ToList() ;
                all = temp;
            }
            if(logSearch.Exception != null)
            {
                var temp = all.Where(x=>x.Exception ==  logSearch.Exception).ToList();
                all = temp;
            }
            return Ok(all);
        }
        [HttpPost("InsertLogEntry")]
        public IActionResult Add(LogEntry enty)
        {
            try
            {
                _sql.Logs.Add(enty);
                _sql.SaveChanges();
                return StatusCode(201);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
