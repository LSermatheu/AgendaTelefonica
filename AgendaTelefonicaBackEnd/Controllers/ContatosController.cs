using AgendaTelefonicaBackEnd.DAO.contatos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaTelefonicaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        [HttpGet("list/{filtro?}")]
        public ActionResult LIST(string? filtro)
        {
            ActionResult result;

            try
            {
                using (var dao = new ContatosDAO())
                    result = Ok(dao.List(filtro ?? ""));
            }
            catch (Exception ex)
            {
                result = BadRequest(ex.Message);
            }

            return result;
        }

        [HttpGet("{int:id}")]
        public ActionResult GET(int id)
        {
            ActionResult result;

            try
            {
                using (var dao = new ContatosDAO())
                    result = Ok(dao.Get(id));
            }
            catch (Exception e)
            {
                result = BadRequest(e.Message);
            }

            return result;
        }

        [HttpPost]
        public ActionResult SAVE([FromBody] Contato obj)
        {
            ActionResult result;

            try
            {
                using (var dao = new ContatosDAO())
                    result = Ok(dao.Save(obj));
            }
            catch (Exception ex)
            {
                result = BadRequest(ex.Message);
            }

            return result;
        }

        [HttpDelete("{id:int}")]
        public ActionResult DELETE(int id)
        {
            ActionResult result;

            try
            {
                using (var dao = new ContatosDAO())
                    result = Ok(dao.Delete(id));
            }
            catch (Exception ex)
            {
                result = BadRequest(ex.Message);
            }

            return result;
        }
    }
}
