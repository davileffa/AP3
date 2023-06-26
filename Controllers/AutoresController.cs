using System;
using System.Collections.Generic;
using AP3.Domain.DTOs;
using AP3.Domain.Entities;
using AP3.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AP3.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IMapper _mapper;

        public AutoresController(IAutorRepository autorRepository, IMapper mapper)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllAutores()
        {
            var autores = _autorRepository.GetAll();
            var autoresDTO = _mapper.Map<List<AutorDTO>>(autores);
            return Ok(autoresDTO);
        }

        [HttpGet("{id}")]
        public IActionResult GetAutorById(int id)
        {
            var autor = _autorRepository.GetById(id);
            if (autor == null)
            {
                return NotFound();
            }

            var autorDTO = _mapper.Map<AutorDTO>(autor);
            return Ok(autorDTO);
        }

        [HttpPost]
        public IActionResult CreateAutor([FromBody] AutorDTO autorDTO)
        {
            if (autorDTO == null)
            {
                return BadRequest();
            }

            var autor = _mapper.Map<Autor>(autorDTO);
            _autorRepository.Add(autor);

            autorDTO.Id = autor.Id; // Atualiza o ID do DTO com o ID gerado no banco de dados

            return Ok(autorDTO);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAutor(int id, [FromBody] AutorDTO autorDTO)
        {
            if (autorDTO == null || autorDTO.Id != id)
            {
                return BadRequest();
            }

            var autor = _autorRepository.GetById(id);
            if (autor == null)
            {
                return NotFound();
            }

            _mapper.Map(autorDTO, autor);
            _autorRepository.Update(autor);

            return Ok(autorDTO);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAutor(int id)
        {
            var autor = _autorRepository.GetById(id);
            if (autor == null)
            {
                return NotFound();
            }

            _autorRepository.Delete(id);

            return NoContent();
        }
    }
}
