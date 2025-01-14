﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoofstockChallenge.Model.DTO;
using RoofstockChallenge.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RoofstockChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly ILogger<PropertyController> _logger;
        private readonly IPropertyService _service;

        public PropertyController(ILogger<PropertyController> logger, IPropertyService service)
        {
            _logger = logger;
            _service = service;
        }

        // GET: api/<PropertyController>
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
             nameof(DefaultApiConventions.Get))]
        public List<PropertyDTO> Get()
        {
            return _service.GetProperties();
        }

        // GET api/<PropertyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PropertyController>
        [HttpPost]
        public void Post([FromBody] PropertyDTO value)
        {
            _service.AddProperty(value);
        }

        // PUT api/<PropertyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PropertyDTO value)
        {
            _service.UpdateProperty(value, id);
        }

        // DELETE api/<PropertyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
