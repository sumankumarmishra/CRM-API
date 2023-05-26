﻿using CRM_api.DataAccess.Helper;
using CRM_api.DataAccess.Models;
using CRM_api.DataAccess.ResponseModel.Generic_Response;

namespace CRM_api.DataAccess.IRepositories.Business_Module.LI_GI_Module
{
    public interface IInsuranceClientRepository
    {
        Task<Response<TblInsuranceclient>> GetInsuranceClients(string search, SortingParams sortingParams);
        Task<TblInsuranceclient> GetInsuranceClientById(int id);
        Task<TblInsuranceTypeMaster> GetInsuranceplanTypeById(int id);
        Task<IEnumerable<TblInsuranceclient>> GetInsClientsForInsPremiumReminder();
        Task<IEnumerable<TblInsuranceclient>> GetInsClientsForInsDueReminder();
        Task<TblInvesmentType> GetInvesmentTypeByName(string name);
        Task<Response<TblInsuranceCompanylist>> GetCompanyListByInsTypeId(int id, SortingParams sortingParams);
        Task<int> AddInsuranceDetail(TblInsuranceclient tblInsuranceclient);
        Task<int> UpdateInsuranceClientDetail(TblInsuranceclient tblInsuranceclient);
        Task<int> DeactivateInsuranceClientDetail(int id);
    }
}
