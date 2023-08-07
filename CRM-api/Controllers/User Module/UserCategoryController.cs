﻿using CRM_api.DataAccess.Models;
using CRM_api.Services.Dtos.AddDataDto.User_Module;
using CRM_api.Services.IServices.User_Module;
using Microsoft.AspNetCore.Mvc;

namespace CRM_api.Controllers.User_Module
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserCategoryController : ControllerBase
    {
        private readonly IUserCategoryService _userCategoryService;

        public UserCategoryController(IUserCategoryService userCategoryService)
        {
            _userCategoryService = userCategoryService;
        }


        #region Add User Category
        [HttpPost("AddUserCategory")]
        public async Task<IActionResult> AddUserCategory(AddUserCategoryDto addUserCategory)
        {
            try
            {
                var flag = await _userCategoryService.AddUserCategoryAsync(addUserCategory);
                return flag != 0 ? Ok(new { Message = "User category added successfully." }) : BadRequest(new { Message = "Unable to add user category." });
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Update User Category
        [HttpPut("UpdateUserCategory")]
        public async Task<IActionResult> UpdateUserCategory(UpdateUserCategoryDto updateUserCategory)
        {
            try
            {
                var flag = await _userCategoryService.UpdateUserCategoryAsync(updateUserCategory);
                return flag != 0 ? Ok(new { Message = "User category updated successfully." }) : BadRequest(new { Message = "Unable to update user category." });
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region De-Activate User Category
        [HttpDelete("DeActivateUserCategory")]
        public async Task<IActionResult> DeActivateUserCategory(int id)
        {
            try
            {
                var flag = await _userCategoryService.DeActivateUserCategoryAsync(id);
                return flag != 0 ? Ok(new { Message = "User category de-activated successfully." }) : BadRequest(new { Message = "Unable to de-activate user category." });
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
