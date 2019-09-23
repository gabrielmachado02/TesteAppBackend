using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteApp.Infraecstruture.Interfaces;
using TesteApp.Model;

namespace TesteApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        public async Task<IActionResult> GetAll()
        {

            var response = await _service.GetAll();

            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var response = await _service.GetByIdAsync(id);

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> PostCliente(Cliente cliente)
        {
            try
            {
                await _service.CreateAsync(cliente);
                return Ok();
            }

            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpPut]
        public async Task<IActionResult> PutCliente(Cliente cliente)
        {
     

            await _service.Update(cliente);
            
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {

            await _service.Delete(id);

            return Ok();
        }
    }
}