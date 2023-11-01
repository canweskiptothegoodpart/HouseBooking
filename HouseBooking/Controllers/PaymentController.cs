﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.IService;
using Model;

namespace HouseBooking.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService, IMapper mapper)
        {
            _paymentService = paymentService;

        }

        [HttpPost]
        public async Task<IActionResult> AddPayment([FromBody] PaymentDTO paymentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _paymentService.AddPaymentAsync(paymentDTO);
            return Ok("Payment added successfully");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPayments()
        {
            var payments = await _paymentService.GetAllPaymentsAsync();
            return Ok(payments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPaymentById(int id)
        {
            var payment = await _paymentService.GetPaymentByIdAsync(id);

            if (payment == null)
            {
                return NotFound("Payment not found");
            }


            return Ok(payment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePayment(int id, [FromBody] PaymentDTO paymentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingPayment = await _paymentService.GetPaymentByIdAsync(id);

            if (existingPayment == null)
            {
                return NotFound("Payment not found");
            }

            await _paymentService.UpdatePaymentAsync(paymentDTO);
            return Ok("Payment updated successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            var existingPayment = await _paymentService.GetPaymentByIdAsync(id);

            if (existingPayment == null)
            {
                return NotFound("Payment not found");
            }

            await _paymentService.RemovePaymentAsync(id);
            return Ok("Payment deleted successfully");
        }
    }
}
