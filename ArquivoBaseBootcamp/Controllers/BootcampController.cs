using ArquivoBaseBootcamp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace ArquivoBaseBootcamp.Controllers
{
    [ApiController]
    [Route("[controller]/api/")]
    public class BootcampController : ControllerBase
    {
        private readonly ILogger<BootcampController> _logger;
        private readonly IBootCampServices _bootcampService;

        public BootcampController(ILogger<BootcampController> logger,IBootCampServices bootcampService)
        {
            _logger = logger;
            _bootcampService = bootcampService;
        }

        /// <summary>
        /// Este endpoint deve consultar as interessadas cadastradas
        /// </summary>
        /// <returns>
        /// Retorna a lista com todas as interessadas cadastradas
        /// </returns>
        [HttpGet]
        public IActionResult ConsultarTodasInteressadas()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este endpoint deve consultar a interessadas cadastradas
        /// </summary>
        /// <returns>
        /// Retorna 200 caso sucesso
        /// Retorna 404 caso erro
        /// </returns>
        [HttpGet]
        [Route("consulta/{email}")]
        public IActionResult ConsultarInteressada()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Este endpoint deve realizar o cadastro de uma interessada
        /// </summary>
        /// <returns>
        /// Retorna 200 caso sucesso
        /// Retorna 404 caso erro
        /// </returns>
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult CadastrarInteressada()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este endpoint deve atualizar os dados das interessadas cadastradas
        /// </summary>
        /// <returns>
        /// Retorna 200 caso sucesso
        /// Retorna 404 caso erro
        /// </returns>
        [HttpPut]
        [Route("atualizar/{email}")]
        public IActionResult AtualizarInteressada()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este endpoint deve excluir as interessadas cadastradas
        /// </summary>
        /// <returns>
        /// Retorna 200 caso sucesso
        /// Retorna 404 caso erro
        /// </returns>
        [HttpDelete]
        [Route("excluir/{email}")]
        public IActionResult ExcluirInteressada()
        {
            throw new NotImplementedException();
        }
    }
}
