using AP3.Domain.DTOs;
using AP3.Domain.Entities;
using AP3.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AP3.Controllers
{
    [ApiController]
    [Route("api/livros")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper _mapper;

        public LivrosController(ILivroRepository livroRepository, IMapper mapper)
        {
            _livroRepository = livroRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllLivros()
        {
            var livros = _livroRepository.GetAll();
            var livrosDTO = _mapper.Map<List<LivroDTO>>(livros);
            return Ok(livrosDTO);
        }

        [HttpGet("{id}")]
        public IActionResult GetLivroById(int id)
        {
            var livro = _livroRepository.GetById(id);
            if (livro == null)
            {
                return NotFound();
            }

            var livroDTO = _mapper.Map<LivroDTO>(livro);
            return Ok(livroDTO);
        }

        [HttpPost]
        public IActionResult CreateLivro([FromBody] LivroDTO livroDTO)
        {
            if (livroDTO == null)
            {
                return BadRequest();
            }

            var livro = _mapper.Map<Livro>(livroDTO);
            _livroRepository.Add(livro);

            var createdLivroDTO = _mapper.Map<LivroDTO>(livro);
            return Ok(createdLivroDTO);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLivro(int id, [FromBody] LivroDTO livroDTO)
        {
            if (livroDTO == null || livroDTO.Id != id)
            {
                return BadRequest();
            }

            var livro = _livroRepository.GetById(id);
            if (livro == null)
            {
                return NotFound();
            }

            _mapper.Map(livroDTO, livro);
            _livroRepository.Update(livro);

            return Ok(livroDTO);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLivro(int id)
        {
            var livro = _livroRepository.GetById(id);
            if (livro == null)
            {
                return NotFound();
            }

            _livroRepository.Delete(id);

            return NoContent();
        }
    }
}
