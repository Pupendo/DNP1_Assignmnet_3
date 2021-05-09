﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Persistence;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticsController : Controller
    {
        private IStatisticsRepo StatisticsModel;

        public StatisticsController(IStatisticsRepo statisticsModel)
        {
            StatisticsModel = statisticsModel;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetAgeGroupAsync([FromQuery] int minimum, [FromQuery] int maximum)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                int count = await StatisticsModel.GetAdultAgeGroupAsync(minimum, maximum);
                return Ok(count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("{color:alpha}")]
        public async Task<ActionResult<double>> GetEyeColorPercentageAsync([FromRoute] string color)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                double number = await StatisticsModel.GetEyeColorPercentageAsync(color);
                return Ok(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}