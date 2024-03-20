using Application.Interfaces;
using Application.ResponseModels;
using Application.Services;
using Application.ViewModels.TimeManagementSystemViewModels;
using Application.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Web.Helpers;
using WebAPI.CustomAuthorize;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TMSController : ControllerBase
    {
        private readonly ITMSService _tmsService;

        public TMSController(ITMSService tmsService)
        {
            _tmsService = tmsService;
        }

        //action

        [HttpPost]
        [Authorize(Roles = "Trainee")]
        public async Task<IActionResult> CreateAbsentRequestAsync([FromForm] string reason)
        {
            var result = await _tmsService.CreateAbsentRequestAsync(reason);

            return result ? Ok(new BaseResponseModel()
            {
                Status = Ok().StatusCode,
                Message = "TMS created successfully!"
            }) : BadRequest(new BaseFailedResponseModel()
            {
                Status = BadRequest().StatusCode,
                Message = "Failed!"
            });
        }

        [Authorize(Roles = "Super Admin, Class Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> ApproveAbsentRequestAsync(int id, [FromForm] string status)
        {
            try
            {

                var checkIdTMS = await _tmsService.GetAbsentRequestByIdAsync(id);

                if (checkIdTMS == null) return NotFound(new BaseFailedResponseModel()
                {
                    Status = NotFound().StatusCode,
                    Message = "Request with ID " + id + " does not exist!"
                });

                var result = await _tmsService.ApproveAbsentRequestAsync(id, status);

                return result ? Ok(new BaseResponseModel()
                {
                    Status = Ok().StatusCode,
                    Message = "TMS status changed successfully!"
                }) : BadRequest(new BaseFailedResponseModel()
                {
                    Status = BadRequest().StatusCode,
                    Message = "Input must be Approved or Declined!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new BaseFailedResponseModel()
                {
                    Status = BadRequest().StatusCode,
                    Message = "Input must be Approved or Declined!"
                });
            }
        }

        [Authorize(Roles = "Super Admin, Class Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllAbsentRequestsAsync()
        {
            var result = await _tmsService.GetAllAbsentRequestsAsync();

            if (result.Count == 0) return NotFound(new BaseFailedResponseModel()
            {
                Status = NotFound().StatusCode,
                Message = "There are no requests in the TMS!"
            });

            return Ok(new BaseResponseModel()
            {
                Status = Ok().StatusCode,
                Message = "List get successfully!",
                Result = result
            });
        }

        [Authorize(Roles = "Super Admin, Class Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllPendingAbsentRequestsAsync()
        {
            var result = await _tmsService.GetAllPendingAbsentRequestsAsync();

            if (result.Count == 0) return NotFound(new BaseFailedResponseModel()
            {
                Status = NotFound().StatusCode,
                Message = "There are no pending requests in the TMS!"
            });

            return Ok(new BaseResponseModel()
            {
                Status = Ok().StatusCode,
                Message = "List get successfully!",
                Result = new
                {
                    item = result,
                    itemCount = result.Count
                }
            });
        }

        [Authorize(Roles = "Super Admin, Class Admin")]
        [HttpPost]
        public async Task<IActionResult> SearchAbsentRequest(string searchBy, [FromForm] string searchElement)
        {
            if (!string.Equals(searchBy, "Name", StringComparison.OrdinalIgnoreCase)
                && !string.Equals(searchBy, "Email", StringComparison.OrdinalIgnoreCase)
                && !string.Equals(searchBy, "Phone", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest(new BaseFailedResponseModel()
                {
                    Status = BadRequest().StatusCode,
                    Message = "searchBy must be Name, Email or Phone!"
                });
            }

            try
            {

                var result = await _tmsService.SearchAbsentRequest(searchBy, searchElement);

                if (result.Count == 0) return NotFound(new BaseFailedResponseModel()
                {
                    Status = NotFound().StatusCode,
                    Message = "Empty!"
                });

                return Ok(new BaseResponseModel()
                {
                    Status = Ok().StatusCode,
                    Message = "List get successfully!",
                    Result = new
                    {
                        item = result,
                        itemCount = result.Count
                    }
                });
            }
            catch (Exception ex)
            {
                return NotFound(new BaseFailedResponseModel()
                {
                    Status = NotFound().StatusCode,
                    Message = "User with Email " + searchElement + " does not exist!"
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> SendAttendanceMailAsync()
        {
            try
            {
                await _tmsService.SendAttendanceMailAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}