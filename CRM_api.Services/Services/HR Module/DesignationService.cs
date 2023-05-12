﻿using AutoMapper;
using CRM_api.DataAccess.IRepositories.HR_Module;
using CRM_api.DataAccess.Models;
using CRM_api.Services.Dtos.AddDataDto.HR_Module;
using CRM_api.Services.Dtos.ResponseDto.HR_Module;
using CRM_api.Services.IServices.HR_Module;

namespace CRM_api.Services.Services.HR_Module
{
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationRepository _designationRepository;
        private readonly IMapper _mapper;

        public DesignationService(IDesignationRepository designationRepository, IMapper mapper)
        {
            _designationRepository = designationRepository;
            _mapper = mapper;
        }

        public async Task<int> AddDesignation(AddDesignationDto designationMaster)
        {
            var mappedDesignation = _mapper.Map<TblDesignationMaster>(designationMaster);
            return await _designationRepository.AddDesignatione(mappedDesignation);
        }

        public async Task<DisplayDesignationDto> GetDesignation(int page)
        {
            var designations = await _designationRepository.GetDesignation(page);
            var mappedDesignation = _mapper.Map<DisplayDesignationDto>(designations);
            return mappedDesignation;
        }

        public async Task<IEnumerable<DesignationDto>> GetDesignationByDepartment(int deptId)
        {
            var designations = await _designationRepository.GetDesignationByDepartment(deptId);
            var mappedDesignation = _mapper.Map<IEnumerable<DesignationDto>>(designations);
            return mappedDesignation;
        }

        public async Task<DesignationDto> GetDesignationById(int id)
        {
            var designation = await _designationRepository.GetDesignationById(id);
            var mapDesignation = _mapper.Map<DesignationDto>(designation);
            return mapDesignation;
        }

        public async Task<int> UpdateDesignation(UpdateDesignationDto designationMaster)
        {
            var designation = _mapper.Map<TblDesignationMaster>(designationMaster);
            return await _designationRepository.UpdateDesignation(designation);
        }
    }
}
