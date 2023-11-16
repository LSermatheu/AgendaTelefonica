using AgendaTelefonica.BackEnd.DAO.contatos;
using Microsoft.AspNetCore.Mvc;

namespace AgendaTelefonica.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private ContatosDAO dao;
        public ContatosController()
        {
            dao = new ContatosDAO();
        }
                
        [HttpGet("list/{filtro?}")]
        public ActionResult LIST(string? filtro = null)
        {
            ActionResult result;

            try
            {
                result = Ok(dao.List(filtro ?? ""));
            }
            catch (Exception ex)
            {
                result = BadRequest(ex.Message);
            }

            return result;
        }

        [HttpGet("{id:int}")]
        public ActionResult GET(int id)
        {
            ActionResult result;

            try
            {
                var obj = dao.Get(id);
                if (obj != null)
                    result = Ok(obj);
                else
                    result = NotFound();
            }
            catch (Exception ex)
            {
                result = BadRequest(ex.Message);
            }

            return result;

        }

        [HttpPost]
        public ActionResult SAVE([FromBody] Contato contatoObj)
        {
            ActionResult result;

            try
            {
                result = Ok(dao.Save(contatoObj));
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
