﻿using CRM_api.DataAccess.Helper;
using CRM_api.DataAccess.Models;
using CRM_api.Services.Dtos.AddDataDto.Business_Module.MGain_Module;
using CRM_api.Services.Dtos.ResponseDto.Business_Module.MGain_Module;
using CRM_api.Services.Dtos.ResponseDto.Generic_Response;

namespace CRM_api.Services.IServices.Business_Module.MGain_Module
{
    public interface IMGainService
    {
        Task<MGainResponseDto<MGainDetailsDto>> GetAllMGainDetailsAsync(int? currancyId, string? type, bool? isClosed, DateTime? fromDate, DateTime? toDate, string? searchingParams, SortingParams sortingParams);
        Task<List<MGainPaymentDto>> GetPaymentByMgainIdAsync(int mGainId);
        Task<string> MGainAggrementAsync(int mGainId);
        Task<MGainPDFResponseDto> GenerateMGainAggrementAsync(int id, string htmlContent);
        Task<MGainPDFResponseDto> MGainPaymentReceipt(int id);
        Task<MGainNCmonthlyTotalDto> GetNonCumulativeMonthlyReportAsync(int month, int year, int? schemeId, decimal? tds, bool? isJournal, DateTime? jvEntryDate, string? jvNarration, bool? isPayment, DateTime? crEntryDate, string? crNarration, string? searchingParams, SortingParams sortingParams);
        Task<List<MGainValuationDto>> GetValuationReportByUserIdAsync(int UserId);
        Task<decimal?> GetMonthWiseInterestPaidAsync(int month, int year);
        Task<ResponseDto<ProjectMasterDto>> GetAllProjectAsync(string? searchingParams, SortingParams sortingParams);
        Task<ResponseDto<PlotMasterDto>> GetPlotsByProjectIdAsync(int projectId, decimal invAmount, string? searchingParams, SortingParams sortingParams);
        Task<List<MGainCurrancyDto>> GetAllCurrenciesAsync();
        Task<TblMgaindetail> AddMGainDetailAsync(AddMGainDetailsDto addMGainDetails);
        Task<int> AddPaymentDetailsAsync(List<AddMGainPaymentDto> paymentDtos);
        Task<int> UpdateMGainDetailsAsync(UpdateMGainDetailsDto updateMGainDetails);
        Task<int> UpdateMGainPaymentAsync(List<UpdateMGainPaymentDto> updateMGainPayment);
        Task<int> DeleteMGainPaymentAsync(int id);
    }
}
