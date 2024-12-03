using Microsoft.AspNetCore.Mvc;
using ProjekatSBP.Entiteti;
using ProjekatSBP;
using System;
using ProjekatSBP.DTOs;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProtivkandidatiController :ControllerBase
    {

        #region Protivkandidati
        [HttpGet]
        [Route("PreuzmiProtivkandidateDuela/{tvDuelID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetProtivkandidateDuela([FromRoute(Name = "tvDuelaID")] int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiProtivkandidateDuela(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajProtivkandidataDuelu/{protivkandidat}/{tvDuelID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddProtivkandidataDuelu([FromRoute(Name = "protivkandidat")] string protivkandidat, [FromRoute(Name = "tvDuelID")] int duel)
        {
            try
            {
                Protivkandidati o = new Protivkandidati();
                o.Id.Protivkandidat = protivkandidat;
                DataProvider.SacuvajProtivkandidata(o, duel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        [HttpDelete]
        [Route("IzbrisiProtivkandidataDuela/{protivkandidat}/{tvDuelID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteProtivkandidataDuela([FromRoute(Name = "protivkandidat")] string protivkandidat, [FromRoute(Name = "tvDuelID")] int duel)
        {

            try
            {
                Protivkandidati pit = new Protivkandidati();
                pit.Id.Protivkandidat = protivkandidat;
                DataProvider.ObrisiProtivkandidata(pit, duel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
