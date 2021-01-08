﻿using BlazorAppCRUD.Server.Data;
using BlazorAppCRUD.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppCRUD.Server.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase {
        private readonly ApplicationDbContext _db;

        public PessoaController(ApplicationDbContext db) {
            _db = db;
        }

        #region GET

        [HttpGet]
        public async Task<ActionResult<List<Pessoa>>> Get() {
            return await _db.Pessoas.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Pessoa>> GetById(int id) {
            return await _db.Pessoas.FirstOrDefaultAsync(x => x.Id == id);
        }

        #endregion

        #region POST

        [HttpPost]
        public async Task<ActionResult> Post(Pessoa pessoa) {
            _db.Add(pessoa);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetById), new { pessoa.Id }, pessoa);
        }

        #endregion

        #region PUT

        [HttpPut]
        public async Task<ActionResult> Put(Pessoa pessoa) {
            _db.Entry(pessoa).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        #endregion

        #region DELETE

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            var pessoa = await _db.Pessoas.FirstOrDefaultAsync(x => x.Id == id);
            _db.Remove(pessoa);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        #endregion
    }
}
