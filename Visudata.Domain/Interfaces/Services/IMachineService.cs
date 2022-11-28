﻿using Microsoft.AspNetCore.Mvc;
using PI.Domain.ViewModel.Machine;

namespace PI.Application.Intefaces;

public interface IMachineService
{
    #region CRUD

    Task<List<MachineForListViewModel>> GetAll(int enterpriseId);
    Task<List<MachineForListViewModel>> GetMachinesForSpecificCategory(int enterpriseId, string categoryName);
    Task<bool> Add(AddMachineViewModel model, string enterpriseCnpj);
    Task<bool> UpdateMachine(EditMachineViewModel model);
    Task<bool> RemoveMachine(int machineId);
    Task<List<MachineForListViewModel>> GetMachinesByEnterpriseId(int enterpriseId);

    #endregion

    
    Task<JsonResult> GetStatusAboutTemp(int machineId, int enterpriseId);
    Task<JsonResult> GetStatusAboutVibration(int machineId, int enterpriseId);
    Task<JsonResult> GetStatusAboutNoise(int machineId, int enterpriseId);
    Task<AmountOfMachineByStatusViewModel> GetAmountOfMachinesByStatusWithEnterpriseId(int enterpriseId);
    Task<bool> AddRegisterOfMachineFromJson(MachineDataRecieveFromSensorsJsonModel model);
    Task<EditMachineViewModel> GetMachineDataForEdit(int machineId);
    Task<List<MachineForListViewModel>> GetMachinesByEnterpriseCnpj(string? enterpriseOfCurrentSessionCnpj);
    Task<string> GetHistoryDataByCsvByMachineId(int machineId);
    Task<MachineDetailsViewModel> GetMachineForDetails(int id);
    Task<string> GetJsonForDetailsAboutMachineAjaxHandler(int id, string status);


}